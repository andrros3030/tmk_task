-- Запрос 1: возвращает данные читателей, у которых большей 1 книги на руках
SELECT *
FROM T_PERSON prsn
WHERE (SELECT COUNT(lnk.PK_ID) FROM t_link lnk where lnk.FK_PERSON = prsn.PK_ID) > 1;

-- Запрос 2: возвращает авторов книг, у которых количество книг больше среднего, отсортированных по количеству книг в порядке уменьшения
with avg_table as (
    SELECT count(bk1.PK_ID) cnt from T_BOOK bk1 GROUP BY bk1.FK_AUTHOR
),
avg_count_result as (
    SELECT AVG(cnt) avg_cnt from avg_table
)
SELECT prsn.*,
       count(bk.PK_ID) as cnt,
       avg_count_result.avg_cnt as avg_cnt
FROM T_PERSON prsn
JOIN T_BOOK bk on prsn.PK_ID = bk.FK_AUTHOR
JOIN avg_count_result
group by bk.FK_AUTHOR
HAVING CNT > avg_cnt
order by cnt desc;

-- Запрос 3: выводит все книги, которые сейчас не у читателей
SELECT *
FROM t_book BK
WHERE (SELECT COUNT(LNK.PK_ID) FROM T_LINK LNK WHERE LNK.FK_BOOK = BK.PK_ID) = 0;