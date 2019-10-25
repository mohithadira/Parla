using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using SurveryGuru.Entity;

namespace SurveryGuru.BussinessLogic
{
    public class Registration
    {
        fileIO file = new fileIO();
        DataBaseHelper dataBaseHelper = new DataBaseHelper();
        
        /// <summary>
        /// To Add new Voter object to the list
        /// </summary>
        /// <param name="_Id"></param>
        /// <param name="_Name"></param>
        /// <param name="_Ward"></param>
        /// <param name="_City"></param>
        /// <param name="_Party"></param>
        /// <param name="_Reason"></param>
        public void AddVoter(string _Id, string _Name, string _Ward, string _City, string _Party, string _Reason)
        {
            //Exception-1
            if (_Id == "" || _Name == "" || _Ward == "" || _City == "" || _Party == "" || _Reason == "" )
            {
                throw new DataEntryException1();
            }
            //Exception-2
            char[] name = _Id.ToArray();
            if ((int)name[0] <= 64 || (int)name[0] >= 91 || (int)name[1] <= 64 || (int)name[1] >= 91)
            {
                throw new DataEntryException2();
            }
            for (int i = 2; i  < name.Length; i++)
            {
                char item = name[i];
                if((int)item >= 58  || (int)item <= 47)
                {
                    throw new DataEntryException2();                    
                }
            }
            //Exception-3
            if(_Name.Length < 4 || _Name.Length > 8)
            {
                throw new DataEntryException3();
            }
            //Execption-4
            if(_Ward != "North" && _Ward != "South" && _Ward != "East" && _Ward != "West")
            {
                throw new DataEntryException4();
            }
            //Exception-5
            if(_Party != "Congress" && _Party != "BJP" && _Party != "JD")
            {
                throw new DataEntryException5();
            }
            //Exeption-6
            if(_Reason.Length >= 200)
            {
                throw new DataEntryException6();
            }

            Voter voter = new Voter();
            voter.voterId = _Id;
            voter.voterName = _Name;
            voter.voterWard = _Ward;
            voter.voterCity = _City;
            voter.voterParty = _Party;
            voter.voterReason = _Reason;

            //Deserializing
            dataBaseHelper.voters = file.VoterDeserialize();

            dataBaseHelper.voters.Add(voter);
            //Serializing
            file.VoterSerialize(dataBaseHelper.voters);
        }

        /// <summary>
        /// To Search for a voter with given voterId
        /// </summary>
        /// <param name="_Id"></param>
        /// <returns></returns>
        public Voter SearchVoter(string _Id)
        {
            //Checking if entered _Id satisfies required conditions
            //Exception-1
            if (_Id == "")
            {
                throw new DataEntryException1();
            }
            //Exception-2
            char[] name = _Id.ToArray();
            if ((int)name[0] <= 64 || (int)name[0] >= 91 || (int)name[1] <= 64 || (int)name[1] >= 91)
            {
                throw new DataEntryException2();
            }
            for (int i = 2; i < name.Length; i++)
            {
                char item = name[i];
                if ((int)item >= 58 || (int)item <= 47)
                {
                    throw new DataEntryException2();
                }
            }

            //Deserializing
            dataBaseHelper.voters = file.VoterDeserialize();

            Voter voter = new Voter();
            voter = null;

            foreach (var item in dataBaseHelper.voters)
            {
                if(item.voterId == _Id)
                {
                    voter = item;
                    break;
                }
            }

            if(voter != null)
            {
                Console.WriteLine($"Voter Id: {voter.voterId}\tVoter Name: {voter.voterName}" +
                    $"\tWard: {voter.voterWard}\nCity: {voter.voterCity}\tState: {voter.voterState}" +
                    $"\tParty to Vote: {voter.voterParty}\nReason to Vote: {voter.voterReason}\n");
            }
            else
            {
                Console.WriteLine("Voter not found!!");
            }

            //Serializing
            file.VoterSerialize(dataBaseHelper.voters);

            return voter;
        }

        /// <summary>
        /// To delete voter with given voterId
        /// </summary>
        /// <param name="_Id"></param>
        public void DeleteVoter(string _Id)
        {
            //Checking if entered _Id satisfies required conditions
            //Exception-1
            if (_Id == "")
            {
                throw new DataEntryException1();
            }
            //Exception-2
            char[] name = _Id.ToArray();
            if ((int)name[0] <= 64 || (int)name[0] >= 91 || (int)name[1] <= 64 || (int)name[1] >= 91)
            {
                throw new DataEntryException2();
            }
            for (int i = 2; i < name.Length; i++)
            {
                char item = name[i];
                if ((int)item >= 58 || (int)item <= 47)
                {
                    throw new DataEntryException2();
                }
            }

            //Deserializing
            dataBaseHelper.voters = file.VoterDeserialize();

            Voter temp = SearchVoter(_Id);
            dataBaseHelper.voters.Remove(temp);

            //Serializing
            file.VoterSerialize(dataBaseHelper.voters);
        }

        /// <summary>
        /// To update details of voter with given voterId
        /// </summary>
        /// <param name="_Id"></param>
        /// <param name="_Name"></param>
        /// <param name="_Ward"></param>
        /// <param name="_City"></param>
        /// <param name="_Party"></param>
        /// <param name="_Reason"></param>
        public void UpdateVoter(string _Id, string _Name, string _Ward, string _City, string _Party, string _Reason)
        {
            //Checking if entered details satisfy required conditions
            //Exception-1
            if (_Id == "" || _Name == "" || _Ward == "" || _City == "" || _Party == "" || _Reason == "")
            {
                throw new DataEntryException1();
            }
            //Exception-2
            char[] name = _Id.ToArray();
            if ((int)name[0] <= 64 || (int)name[0] >= 91 || (int)name[1] <= 64 || (int)name[1] >= 91)
            {
                throw new DataEntryException2();
            }
            for (int i = 2; i < name.Length; i++)
            {
                char item = name[i];
                if ((int)item >= 58 || (int)item <= 47)
                {
                    throw new DataEntryException2();
                }
            }
            //Exception-3
            if (_Name.Length < 4 || _Name.Length > 8)
            {
                throw new DataEntryException3();
            }
            //Execption-4
            if (_Ward != "North" && _Ward != "South" && _Ward != "East" && _Ward != "West")
            {
                throw new DataEntryException4();
            }
            //Exception-5
            if (_Party != "Congress" && _Party != "BJP" && _Party != "JD")
            {
                throw new DataEntryException5();
            }
            //Exeption-6
            if (_Reason.Length >= 200)
            {
                throw new DataEntryException6();
            }

            //Deserializing
            dataBaseHelper.voters = file.VoterDeserialize();

            Voter temp = SearchVoter(_Id);
            temp.voterId = _Id;
            temp.voterName = _Name;
            temp.voterWard = _Ward;
            temp.voterCity = _City;
            temp.voterParty = _Party;
            temp.voterReason = _Reason;

            //Serializing
            file.VoterSerialize(dataBaseHelper.voters);
        }
        
        /// <summary>
        /// To view details of all voters
        /// </summary>
        public void ViewAllVoter()
        {
            //Deserializing
            dataBaseHelper.voters = file.VoterDeserialize();

            foreach (var voter in dataBaseHelper.voters)
            {
                Console.WriteLine($"Voter Id: {voter.voterId}\nVoter Name: {voter.voterName}" +
                    $"\nWard: {voter.voterWard}\nCity: {voter.voterCity}\nState: {voter.voterState}" +
                    $"\nParty to Vote: {voter.voterParty}\nReason to Vote: {voter.voterReason}\n\n");
            }

            //Serializing
            file.VoterSerialize(dataBaseHelper.voters);
        }
        
    }

}
