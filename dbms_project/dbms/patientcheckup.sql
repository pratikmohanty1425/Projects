create table patientCheckup
(
pcu_id bigint not null identity primary key,
pcu_appID bigint not null foreign key references patientAppointment(pa_id) on delete cascade on update cascade,
pcu_remarks varchar(1000) not null default '-',
pcu_fees money not null default 0
)