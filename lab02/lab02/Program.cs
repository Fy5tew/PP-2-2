﻿namespace lab02 {
    internal class Program {
        static void Main(string[] args) {
            University univer = new University("Belarusian State Technological University", "BSTU", "Belarus, Minsk");

            Faculty fit = new Faculty("Faculty of Information Technologies", "FIT", "100-4");
            Faculty tov = new Faculty("Technologies of Organic Subjects", "TOV", "307-1");

            fit.addDepartment(new Department());
            fit.addDepartment(new Department());
            fit.addDepartment(new Department());
            fit.addDepartment(new Department());

            tov.addDepartment(new Department());
            tov.addDepartment(new Department());
            tov.addDepartment(new Department());

            univer.addFaculty(fit);
            univer.addFaculty(tov);

            univer.printInfo();
            foreach (Faculty faculty in univer.getFaculties()) {
                faculty.printInfo();
            }
        }
    }
}