use TimeBank
go
alter table ReportsDetails
add constraint 
unique_report_and_waiting_report_detailss unique (member, reportId)

--alter table categories
--add constraint
--self_fk foreign key (fatherCategoryId)

