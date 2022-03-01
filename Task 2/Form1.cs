using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Tube> session_list = new List<Tube>();
        List<int> actual_indexes = new List<int>();
        int editable_index = -1;
        private void Form1_Load(object sender, EventArgs e)
        {
            Dimensions classic_dimentions = new Dimensions(1000.0, 20.0, 20.0);
            session_list.Add(new Tube(0, classic_dimentions, 5.0, steel_type.steel1));
            session_list.Add(new Tube(1, classic_dimentions, 5.0, steel_type.steel2));
            session_list.Add(new Tube(2, classic_dimentions, 5.0, steel_type.steel3, false));
            Fill_table();
            steel_selector.Items.Clear();
            steel_selector.Items.Add("steel1");
            steel_selector.Items.Add("steel2");
            steel_selector.Items.Add("steel3");
            steel_selector.SelectedIndex = 0;
        }
        private void Fill_table()
        {
            table.Controls.Clear();
            actual_indexes.Clear();
            if (session_list.Count > 0)
            {
                foreach (KeyValuePair<string, dynamic> el in session_list[0].get_data())
                {
                    Label tmp = new Label();
                    tmp.Text = el.Key.ToString();
                    tmp.AutoSize = true;
                    table.Controls.Add(tmp);
                }
                Label empty_field = new Label();
                empty_field.AutoSize = true;
                table.Controls.Add(empty_field);
                Label empy_field_2 = new Label();
                empy_field_2.AutoSize = true;
                table.Controls.Add(empy_field_2);
            }
            for (int i = 0; i < session_list.Count; ++i)
            {
                actual_indexes.Add(i);
                foreach (KeyValuePair<string, dynamic> el in session_list[i].get_data())
                {
                    Label tmp = new Label();
                    tmp.Text = el.Value.ToString();
                    tmp.AutoSize = true;
                    table.Controls.Add(tmp);
                }
                Button remove = new Button();
                remove.Text = "Удалить";
                remove.Name = i.ToString();
                remove.Click += new EventHandler(remove_item);
                remove.AutoSize = true;
                table.Controls.Add(remove);
                Button edit = new Button();
                edit.Text = "Изменить";
                edit.Name = i.ToString();
                edit.Click += new EventHandler(edit_item);
                edit.AutoSize = true;
                table.Controls.Add(edit);
            }
        }
        private void Add_tube(Tube new_tube, int index)
        {
            actual_indexes.Add(index);
            foreach (KeyValuePair<string, dynamic> el in new_tube.get_data())
            {
                Label tmp = new Label();
                tmp.Text = el.Value.ToString();
                tmp.AutoSize = true;
                table.Controls.Add(tmp);
            }
            Button remove = new Button();
            remove.Text = "Удалить";
            remove.Name = index.ToString();
            remove.Click += new EventHandler(remove_item);
            remove.AutoSize = true;
            table.Controls.Add(remove);
            Button edit = new Button();
            edit.Text = "Изменить";
            edit.Name = index.ToString();
            edit.Click += new EventHandler(edit_item);
            edit.AutoSize = true;
            table.Controls.Add(edit);
        }
        private void Update_tube(int index)
        {
            int f_index = actual_indexes.Where((it, i2) => { return it == index; }).First();
            int s_index = actual_indexes.IndexOf(f_index);
            System.Diagnostics.Debug.WriteLine(f_index);
            System.Diagnostics.Debug.WriteLine(s_index);
            for (int _ = 0; _ < table.ColumnCount; _++)
                table.Controls.Remove(table.GetControlFromPosition(0, s_index + 1));
            /*
             int i = 0;
            foreach (KeyValuePair<string, dynamic> el in session_list[index].get_data())
            {
                Label tmp = new Label();
                tmp.Text = el.Value.ToString();
                tmp.AutoSize = true;
                table.Controls.Add(tmp, i, s_index + 1);
                i++;
            }
            Button remove = new Button();
            remove.Text = "Удалить";
            remove.Name = index.ToString();
            remove.Click += new EventHandler(remove_item);
            remove.AutoSize = true;
            table.Controls.Add(remove, i, s_index + 1);
            Button edit = new Button();
            edit.Text = "Изменить";
            edit.Name = index.ToString();
            edit.Click += new EventHandler(edit_item);
            edit.AutoSize = true;
            table.Controls.Add(edit, i+1, s_index + 1);
             */

        }
        private void create_new_button_Click(object sender, EventArgs e)
        {
            if (editable_index == -1)
            {
                try
                {
                    Tube new_tube = new Tube(int.Parse(number_field.Text), new Dimensions(double.Parse(size_X.Text),
                        double.Parse(size_Y.Text), double.Parse(size_Z.Text)), double.Parse(weight_field.Text),
                        (steel_type)Enum.Parse(typeof(steel_type), steel_selector.Text), is_good.Checked);
                    if (actual_indexes.Count != 0)
                        Add_tube(new_tube, actual_indexes.Max());
                    else
                        Add_tube(new_tube, 0);
                    session_list.Add(new_tube);
                    clear_fields();
                    //Fill_table();
                }
                catch
                {
                    MessageBox.Show("Bad data!");
                }
            }
            else
            {
                try
                {
                    Dimensions _new_dimensions = new Dimensions(double.Parse(size_X.Text), double.Parse(size_Y.Text), double.Parse(size_Z.Text));
                    double _new_weight = double.Parse(weight_field.Text);
                    steel_type _new_type = (steel_type)Enum.Parse(typeof(steel_type), steel_selector.Text);
                    bool _new_state = is_good.Checked;
                    session_list[editable_index].set_size(_new_dimensions);
                    session_list[editable_index].set_type(_new_type);
                    session_list[editable_index].set_weight(_new_weight);
                    session_list[editable_index].set_state(_new_state);
                    Update_tube(editable_index);
                    clear_fields();
                    //Fill_table();
                }
                catch
                {
                    MessageBox.Show("Bad data!");
                }
            }
        }
        private void remove_item(object sender, EventArgs e)
        {
            clear_fields();
            Button current = sender as Button;
            int f_index = actual_indexes.Where((i, index) => { return i == int.Parse(current.Name); }).First();
            //System.Diagnostics.Debug.WriteLine(s_index);
            int s_index = actual_indexes.IndexOf(f_index);
            actual_indexes.Remove(f_index);
            session_list.RemoveAt(s_index);
            for (int i = 0; i < table.ColumnCount; i++)
                table.Controls.Remove(table.GetControlFromPosition(0, s_index + 1));
            //Fill_table();
        }
        private void edit_item(object sender, EventArgs e)
        {
            cancel_button.Enabled = true;
            number_field.Enabled = false;
            Button current = sender as Button;
            Dictionary<string, dynamic> _current = session_list[int.Parse(current.Name)].get_data();
            editable_index = int.Parse(current.Name);
            Dimensions _size = (Dimensions)_current["size"];
            number_field.Text = _current["id"].ToString();
            weight_field.Text = _current["weight"].ToString();
            size_X.Text = _size.size_x.ToString();
            size_Y.Text = _size.size_y.ToString();
            size_Z.Text = _size.size_y.ToString();
            steel_selector.SelectedItem = _current["steel"].ToString();
            is_good.Checked = _current["state"];
        }
        private void clear_fields()
        {
            editable_index = -1;
            cancel_button.Enabled = false;
            number_field.Enabled = true;
            number_field.Clear();
            weight_field.Clear();
            size_X.Clear();
            size_Y.Clear();
            size_Z.Clear();
            steel_selector.SelectedIndex = 0;
            is_good.Checked = true;
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            clear_fields();
        }
    }
}

enum steel_type
{
    steel1,
    steel2,
    steel3
}
class Dimensions
{
    public double size_x;
    public double size_y;
    public double size_z;
    public Dimensions(double x, double y, double z)
    {
        this.size_x = x;
        this.size_y = y;
        this.size_z = z;
    }
    public override string ToString()
    {
        return String.Format("({0}, {1}, {2})", size_x, size_y, size_z);
    }
}
class Tube
{
    private int number;
    private bool state;
    private steel_type type;
    private Dimensions size;
    private double weight;
    /// <summary>
    /// Труба с определенными свойствами
    /// </summary>
    /// <param name="number">№ трубы</param>
    /// <param name="dimensions">размеры</param>
    /// <param name="weight">вес</param>
    /// <param name="type">марка стали</param>
    /// <param name="state">качество (1 - годная, 0 - брак)</param>
    public Tube(int number, Dimensions size, double weight, steel_type type, bool state = true)
    {
        this.number = number;
        this.size = size;
        this.weight = weight;
        this.type = type;
        this.state = state;
    }
    /// <summary>
    /// Получить свойства трубы
    /// </summary>
    /// <returns>Словарь с ключами ["id", "state", "steel", "size", "weight"]</returns>
    public Dictionary<string, dynamic> get_data()
    {
        Dictionary<string, dynamic> result = new Dictionary<string, dynamic>();
        result["id"] = this.number;
        result["state"] = this.state;
        result["steel"] = this.type;
        result["size"] = this.size;
        result["weight"] = this.weight;
        return result;
    }
    public void set_size(Dimensions size)
    {
        this.size = size;
    }
    public void set_weight(double weight)
    {
        this.weight = weight;
    }
    public void set_type(steel_type type)
    {
        this.type = type;
    }
    public void set_state(bool state)
    {
        this.state = state;
    }
}
