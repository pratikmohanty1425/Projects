create table PatientTests
(
pd_id bigint not null identity primary key,
pd_appointmentId bigint not null foreign key references patientAppointment(pa_id) on delete cascade on update cascade,
pd_testID int not null foreign key references tests(t_id) on delete no action on update no action
)