create table patientAppointment
(
pa_id bigint not null identity primary key,
pa_date datetime not null,
pa_turnNumber smallint not null,
pa_doctorID int not null foreign key references Staff(s_id) on delete no action on update no action,
pa_patientID bigint not null foreign key references PatientReg(pr_id) on delete cascade on update cascade,
pa_status tinyint not null
)