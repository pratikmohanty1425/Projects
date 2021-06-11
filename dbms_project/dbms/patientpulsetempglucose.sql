create table patientPulseTempGlucose
(
pp_id bigint not null identity primary key,
pp_appointmentId bigint not null foreign key references patientAppointment(pa_id) on delete cascade on update cascade,
pp_pulse varchar(10) not null,
pp_temp varchar(10) not null,
pp_glucose varchar(10) not null
)