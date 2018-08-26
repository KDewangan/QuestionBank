Create Database QuestionBank;

Create table tbl_User(UserId int primary key identity(1,1),EmailId varchar(50),FullName varchar(200),UserName varchar(150),Password varchar(150),CreatedDate date,Active bit);

create table tbl_Subject(SubjectId int primary key, SubjectName varchar(70));

create table tbl_Quetion_English(e_questionId int primary key identity(1,1),subjectId int foreign key references tbl_Subject(SubjectId),eng_question varchar(max),questionNo int not null,solution varchar(max),Que_ref_img varchar(max));

create table tbl_que_Option( optionId int primary key identity (1,1), questionId int,subjectId int, Option1 varchar(max),Option2 varchar(max),Option3 varchar(max), Option4 varchar(max),Option5 varchar(max) ,primary key(optionId,questionId,subjectId));

create table Answer (AnswerId int primary key identity(1,1), questionId int, subjectId int,answer varchar(max),ans_value int, primary key(questionId,subjectId));

create table Practice_set 


create table Test_Exam(examId int primary key identity(1,1), examDate date, duration int,total_question int);
create table TestExam_Question(q_id int primary key identity(1,1), examId int foreign key references Test_Exam(examId),questionNumber int unique not null, question varchar(max), que_ref_img varchar(300));
create table Test_Exam_Question_Option(optionId int primary key identity (1,1), questionId int,subjectId int, Option1 varchar(max),Option2 varchar(max),Option3 varchar(max), Option4 varchar(max),Option5 varchar(max));
