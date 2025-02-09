﻿using PrescriptionBE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PrescriptionBL
{
    /// <summary>
    /// add more functions of course, these are just the basic fanctions for the mean time
    /// </summary>
    public interface IBL
    {
        //------------ Administrators ---------------
        public void addAdministrator(Administrator administrator);
        public void deleteAdministrator(Administrator administrator);
        public void updateAdministrator(Administrator administrator);
        public bool isAdministrator(string username, string password);
        public Administrator getAdministrator(int id);
        public Administrator getAdministrator();  
        public IEnumerable<Administrator> getAllAdministrators();


        //------------ Doctors ---------------
        public void addDoctor(Doctor doctor);
        public void deleteDoctor(Doctor doctor);
        public void updateDoctor(Doctor doctor);
        public void doctorEntrance(string name, string id);
        public Doctor getDoctor(string id);

        public IEnumerable<Doctor> getAllDoctors();
        public IEnumerable<Prescription> allPrescriptionByDoctor(Doctor doctor);

        //------------ Medicines ---------------
        public void addMedicine(Medicine medicine);
        public void addMedicine(Medicine medicine, HttpPostedFileBase file);
        public void deleteMedicine(Medicine medicine);
        public void updateMedicine(Medicine medicine);
        public void updateMedicinePicture(int medicineId, HttpPostedFileBase file);
        public string getMedicinePicture(int medicinId);
        public Medicine getMedicine(int id);
        public IEnumerable<Medicine> getAllMedicines();

        //------------ Patients ---------------
        public void addPatient(Patient patient);
        public void deletePatient(Patient patient);
        public void updatePatient(Patient patient);
        public Patient getPatient(string id);
        public IEnumerable<Patient> getAllPatients();

        //------------ Prescriptions ---------------
        public void addPrescription(Prescription prescription);
        public Prescription getPrescription(int id);
        public IEnumerable<Prescription> getAllPrescriptions();
        public IEnumerable<Prescription> allPrescriptionFromPatient(Patient patient);

        //------------ Specialties ---------------
        public void addSpecialty(Specialty specialty);
        public void deleteSpecialty(Specialty specialty);
        public Specialty getSpecialty(int id);
        public IEnumerable<Specialty> getAllSpecialties();

        //------------ Statistics ---------------
        public int[][] MedicinesStatistics(IEnumerable<int> medicinesID, int numMonthAgo, ref string[] medicineNamesArr);
        public Doctor IsDoctor(string name, DateTime licenseExpirationDate);
        public int medicinePerPeriod(string medicine, DateTime startDate, DateTime endDate);
        public void ImportDataFromExcel();
        public List<int> info(string MedicineName, int year);

    }
}