﻿using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Convert
{
     public class FitnessTrainersConvert
    {
        public static List<ClassFitnessTrainers> GetAllFitnessTrainers(List<Dal.FitnessTrainers> allft)
        {

            List<ClassFitnessTrainers> Dtoft = new List<ClassFitnessTrainers>();
            foreach (var item in allft)
            {
                ClassFitnessTrainers f = new ClassFitnessTrainers()
                {
                    guide_id= item.guide_id,
                    specialty=item.specialty,
                    phone_num=item.phone_num,
                    email=item.email,
                    name = item.name
                 };
                Dtoft.Add(f);
            }
            return Dtoft;
        }

      

        public static ClassFitnessTrainers GetDtoFitnessTrainer(Dal.FitnessTrainers ft)
        {
            ClassFitnessTrainers fit  = new ClassFitnessTrainers()
            {
                guide_id = ft.guide_id,
                specialty = ft.specialty,
                phone_num = ft.phone_num,
                email = ft.email,
                name = ft.name
            };

            return fit;
        }
        public static Dal.FitnessTrainers PostFitnessTrainer(ClassFitnessTrainers ft)
        {
            Dal.FitnessTrainers f = new Dal.FitnessTrainers()
            {
                guide_id = ft.guide_id,
                specialty = ft.specialty,
                phone_num = ft.phone_num,
                email = ft.email,
                name = ft.name
            };

            return f;
        }
    }
}

