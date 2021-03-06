﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDataProgram.Core.DataBase
{
    /// <summary>
    /// Проект
    /// </summary>
    public class Project : Entity
    {
        /// <summary>
        /// Наименование проекта
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Наименование компании-заказчика
        /// </summary>
        public string CustomerCompany {get; set; }

        /// <summary>
        /// Наименование компании-исполнителя
        /// </summary>
        public string ContractorCompany { get; set; }

        /// <summary>
        /// Руководитель проекта
        /// </summary>
        public User SupervisorUser { get; set; }

        /// <summary>
        /// Руководитель проекта
        /// </summary>
        public int SupervisorUserId { get; set; }

        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime DateBegin { get; set; }

        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateTime DateEnd { get; set; }
        
        /// <summary>
        /// Приоритет
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Исполнители
        /// </summary>
        public virtual List<ProjectUser> ProjectUsers { get; set; }

        /// <summary>
        /// Задачи
        /// </summary>
        public virtual List<ProjectTask> Tasks { get; set; }

        public Project()
        {
            Name = string.Empty;
            CustomerCompany = string.Empty;
            ContractorCompany = string.Empty;
            ProjectUsers = new List<ProjectUser>();
            Tasks = new List<ProjectTask>();
        }
    }
}
