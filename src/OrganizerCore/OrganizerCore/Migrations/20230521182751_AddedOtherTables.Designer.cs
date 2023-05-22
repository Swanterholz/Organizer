﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrganizerCore.DbWorking;

#nullable disable

namespace OrganizerCore.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230521182751_AddedOtherTables")]
    partial class AddedOtherTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("OrganizerCore.Model.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Duration")
                        .HasColumnType("REAL");

                    b.Property<int>("LessonsCount")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("OrganizerCore.Model.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BeginningDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndingDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("MaxAge")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxStudentsInGroupCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MinAge")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("OrganizerCore.Model.GroupCoursesOfStudent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GroupId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Indicator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("LessonsCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("StudentId");

                    b.ToTable("GroupCourses");
                });

            modelBuilder.Entity("OrganizerCore.Model.IndividualCoursesOfStudent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BeginningDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndingDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Indicator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("LessonsCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("IndividualCourses");
                });

            modelBuilder.Entity("OrganizerCore.Model.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("HoursAmount")
                        .HasColumnType("REAL");

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TopicId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.HasIndex("TypeId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("OrganizerCore.Model.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GroupCoursesOfStudentId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("IndividualCoursesOfStudentId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHeld")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ScheduledTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GroupCoursesOfStudentId");

                    b.HasIndex("IndividualCoursesOfStudentId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("OrganizerCore.Model.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProxyFullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProxyPhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("OrganizerCore.Model.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("OrganizerCore.Model.TypeOfLesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TypesOfLessons");
                });

            modelBuilder.Entity("OrganizerCore.Model.Group", b =>
                {
                    b.HasOne("OrganizerCore.Model.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("OrganizerCore.Model.GroupCoursesOfStudent", b =>
                {
                    b.HasOne("OrganizerCore.Model.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrganizerCore.Model.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("OrganizerCore.Model.IndividualCoursesOfStudent", b =>
                {
                    b.HasOne("OrganizerCore.Model.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrganizerCore.Model.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("OrganizerCore.Model.Lesson", b =>
                {
                    b.HasOne("OrganizerCore.Model.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrganizerCore.Model.TypeOfLesson", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topic");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("OrganizerCore.Model.Schedule", b =>
                {
                    b.HasOne("OrganizerCore.Model.GroupCoursesOfStudent", "GroupCoursesOfStudent")
                        .WithMany()
                        .HasForeignKey("GroupCoursesOfStudentId");

                    b.HasOne("OrganizerCore.Model.IndividualCoursesOfStudent", "IndividualCoursesOfStudent")
                        .WithMany()
                        .HasForeignKey("IndividualCoursesOfStudentId");

                    b.Navigation("GroupCoursesOfStudent");

                    b.Navigation("IndividualCoursesOfStudent");
                });

            modelBuilder.Entity("OrganizerCore.Model.Topic", b =>
                {
                    b.HasOne("OrganizerCore.Model.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });
#pragma warning restore 612, 618
        }
    }
}
