using HospitalManagementSystem.HMS.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.HMS.BussinessLogicLayer
{
    class BL
    {
        List<Patient> patients = new List<Patient>();
        List<LabReport> labReports = new List<LabReport>();

        void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }

        void UpdatePatient(Patient patient)
        {
            Patient temp = patients.Find(x => x.patientID.Equals(patient.patientID));
            temp = patient;
        }

        Patient SearchPatient(int pId)
        {
            Patient temp = patients.Find(x => x.patientID.Equals(patient.patientID));
            return temp;
        }

        void ViewPatients()
        {
            foreach (var item in patients)
            {
                Console.Write($"Patient ID : {item.patientID}\t");
                Console.Write($"Patient Name : {item.patientName}\n");
                Console.Write($"Gender : {item.patientGender}\t");
                Console.Write($"Age : {item.patientAge}\n");
                Console.Write($"Address : {item.patientAddress}\n");
                Console.Write($"Contact Number : {item.patientContact}\n");
                Console.Write($"Weight : {item.patientWeight}");
            }
        }

        void AddReport(LabReport labReport)
        {
            labReports.Add(labReport);

            Console.Write($"Report ID : {labReport.reportID}\t");
            Console.Write($"Patient Name : {labReport.patientName}\n");
            Console.Write($"Test Date : {labReport.testDate}\t");
            Console.Write($"Test Type : {labReport.testType}\n");
            Console.Write($"Doctor Name : {labReport.doctor}\n");
            Console.Write($"Remarks : {labReport.remarks}\n");
    }
}
