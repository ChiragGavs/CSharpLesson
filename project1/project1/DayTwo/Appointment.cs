using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.DayTwo
{
    internal class Appointment
    {
        public string AppointmentID {  get; set; } = string.Empty;
        public string appointmentTitle { get; set;} = string.Empty;
        public string appointmentDate { get; set;} = string.Empty;
        public string appointmentType { get; set; } = string.Empty;
        public string appointmentDescription { get; set;} = string.Empty;
        public string PersonName { get; set; } =  String.Empty;
        public string PersonAge { get; set; } = string.Empty;
        public string PersonGender { get; set; } = string.Empty;
        public string PersonPhone { get; set;} = String.Empty;
        public string PersonEmail { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"appointment id : {this.AppointmentID},title: {appointmentTitle}, date: {appointmentDate}, type: {appointmentType}, desc:{appointmentDescription}"+
                   $"person name: {PersonName}, age {PersonAge}, phone: {PersonPhone}, person email: {PersonEmail}";
        }
    }

    internal class TestAppointment
    {
        public static void TestOne()
        {
            Appointment appointment = new Appointment();
            appointment.AppointmentID = "today0001";
            appointment.appointmentTitle = "BusinessDeal";
            appointment.appointmentDescription = "important";
            appointment.appointmentDate = "20-10-2023";
            appointment.PersonName = "krishna";
            appointment.PersonAge = "23";
            appointment.PersonGender = "male";
            appointment.PersonPhone = "99999999999";
            appointment.PersonEmail = "krishna@gmail.com";
            string value = appointment.ToString();
            Console.WriteLine(value);
        }
    }
}
