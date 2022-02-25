INSERT INTO t_person(PK_ID, PV_NAME) VALUES ('GUID0', 'Иванов Иван');
INSERT INTO t_person(PK_ID, PV_NAME) VALUES ('GUID1', 'Петров Петр');
INSERT INTO t_person(PK_ID, PV_NAME) VALUES ('GUID2', 'Сидоров Сергей');
INSERT INTO t_person(PK_ID, PV_NAME) VALUES ('GUID3', 'Авторов Автор');
INSERT INTO t_book(PK_ID, FK_AUTHOR, PV_NAME) VALUES ('BOOK0', 'GUID3', 'Хорошая книга');
INSERT INTO t_book(PK_ID, FK_AUTHOR, PV_NAME) VALUES ('BOOK1', 'GUID3', 'Продолжение хорошей книги');
INSERT INTO t_book(PK_ID, FK_AUTHOR, PV_NAME) VALUES ('BOOK2', 'GUID2', 'Любительский журнал');
INSERT INTO t_book(PK_ID, FK_AUTHOR, PV_NAME) VALUES ('BOOK3', 'GUID3', 'Ужасная книга которуб никто не берет');
INSERT INTO t_link(PK_ID, FK_PERSON, FK_BOOK) VALUES ('link_guid0', 'GUID0', 'BOOK0');
INSERT INTO t_link(PK_ID, FK_PERSON, FK_BOOK) VALUES ('link_guid1', 'GUID1', 'BOOK0');
INSERT INTO t_link(PK_ID, FK_PERSON, FK_BOOK) VALUES ('link_guid2', 'GUID1', 'BOOK1');
INSERT INTO t_link(PK_ID, FK_PERSON, FK_BOOK) VALUES ('link_guid3', 'GUID2', 'BOOK2');