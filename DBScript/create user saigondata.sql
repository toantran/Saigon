--create user saigondata identified by saigon;

grant create session, create table, create procedure,
        create sequence, create view, create trigger,
        create synonym, create materialized view,
        query rewrite, create any directory, create type,
        dba, aq_administrator_role to saigondata ;
    