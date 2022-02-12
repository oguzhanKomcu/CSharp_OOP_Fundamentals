using Abstraction.Buisness.Repositories;
using Abstraction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGame_Project.Business.Data;
using WarGame_Project.Model;
using WarGame_Project.Model.Entities.Concrete;

namespace WarGame_Project.Business.Repositories.Concrete
{
    internal class WarCharacterRepository : BaseRepository<WarCharacter>
    {
        public override void Create(WarCharacter entity)
        {
      
            FakeDatas.warCharacters.Add(entity);   
        }

        public override void Delete(WarCharacter entity)
        {
            entity.Status = Status.Passive;
        }

        public override List<WarCharacter> GetAll()
        {
     
            List<WarCharacter> warCharacters = FakeDatas.warCharacters.ToList();
            return warCharacters;   
        }

        public override WarCharacter GetById(int id)
        {


            WarCharacter warCharacterfinded = new WarCharacter();
            foreach (WarCharacter character in FakeDatas.warCharacters)
            {
                if(character.Id == id)
                {
                    warCharacterfinded = character; 
                }

            }

            return warCharacterfinded;  



        }

        public override void Update(WarCharacter entity)
        {

            WarCharacter warCharacter = GetById(entity.Id);


            warCharacter.Rank = entity.Rank;
            warCharacter.Weapon = entity.Weapon;
            warCharacter.Physic = entity.Physic;
            warCharacter.Talent = entity.Talent;


        }




        public int RS(WarCharacter entity)
        {
            WarCharacter warCharacter = GetById(entity.Id);
            Random random = new Random();
            int strength = 0;

            switch (warCharacter.Rank)
            {
                case "Private First Class (PFC)":
                    strength = 20 + random.Next(1, 50);
                    break;
                case "Sergeant(SGT)":
                    strength = 35 + random.Next(1, 50);
                    break;
                case "Sergeant SV":
                    strength = 50 + random.Next(1, 50);
                    break;
                case "Second Lieutenant (2LT)":
                    strength = 65 + random.Next(1, 50);
                    break;
                case "Captain (CPT)":
                    strength = 75 + random.Next(1, 50);
                    break;
                case "Colonel (COL)":
                    strength = 85 + random.Next(1, 50);
                    break;
                case "Genel (GEN)":
                    strength = 100 + random.Next(1, 50);
                    break;
            }
            return strength;
        }
        public int WS(WarCharacter entity)
        {
            WarCharacter warCharacter = GetById(entity.Id);
            Random random = new Random();
            int strength = 0;
            switch (warCharacter.Weapon)
            {
                case "AK-47":
                    strength = 70 + random.Next(1, 50);
                    break;
                case "M16":
                    strength = 55 + random.Next(1, 50);
                    break;
                case "QXR":
                    strength = 45 + random.Next(1, 50);
                    break;
                case "AWP":
                    strength = 90 + random.Next(1, 50);
                    break;
                case "UMP-45":
                    strength = 50 + random.Next(1, 50);
                    break;
                case "M60":
                    strength = 75 + random.Next(1, 50);
                    break;

            }
            return strength;
        }

        public int PS(WarCharacter entity)
        {
            WarCharacter warCharacter = GetById(entity.Id);
            Random random = new Random();
            int strength = 0;
            switch (warCharacter.Physic)
            {
                case "LARGE":
                    strength = 85 + random.Next(1, 50);
                    break;
                case "WEAK":
                    strength = 55 + random.Next(1, 50);
                    break;
                case "MUSCLE":
                    strength = 75 + random.Next(1, 50);
                    break;
                case "RICKETY":
                    strength = 45 + random.Next(1, 50);
                    break;
                case "MIDDLE":
                    strength = 65 + random.Next(1, 50);
                    break;


            }
            return strength;

        }
        public int TS(WarCharacter entity)
        {
            WarCharacter warCharacter = GetById(entity.Id);
            Random random = new Random();
            int strength = 0;

            switch (warCharacter.Talent)
            {
                case "FAST":
                    strength = 85+random.Next(1,50);
                    break;
                case "STRONG":
                    strength = 75 + random.Next(1, 50);
                    break;
                case "INTELLIGENT":
                    strength = 60 + random.Next(1, 50);
                    break;
                case "AGILE":
                    strength = 65 + random.Next(1, 50);
                    break;
                case "EXPERT":
                    strength =95 + random.Next(1, 50);
                    break;
            }
            return strength;
        }

        public int DL(WarCharacter entity)
        {
            WarCharacter warCharacter = GetById(entity.Id);
            Random random = new Random();

            int strength = 0;

            switch (warCharacter.Diffucality_Level)
            {
                case "HARD":
                    strength = random.Next(70, 100) ;
                    break;
                case "NORMAL":
                    strength = random.Next(45, 70) ;
                    break;
                case "EASY":
                    strength = random.Next(20, 45) ;
                    break;

            }
            return strength;

        }


        public int Totalstrentgh(int id)
        {
            WarCharacterRepository warCharacterRepository = new WarCharacterRepository();
          
            WarCharacter character = warCharacterRepository.GetById(id);
            int totalstrength = (warCharacterRepository.PS(character) + warCharacterRepository.RS(character) + warCharacterRepository.WS(character) + warCharacterRepository.TS(character)) / 4;

            return totalstrength;   
        } 


    }
}
