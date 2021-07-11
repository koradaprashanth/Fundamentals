using System;
using System.Collections.Generic;

namespace MultiValueDictionary
{
    class MultiValueDictionary : IDictionaryApp
    {
        private static Dictionary<string,List<string>> multiValDictionary = new Dictionary<string, List<string>>();
        private static IDictionaryApp _dictionaryApp = new MultiValueDictionary();
        
        static void Main(string[] args)
        {
            string enteredString;
            do 
            { 
                enteredString = Console.ReadLine();
                if (String.IsNullOrEmpty(enteredString))
                    Console.WriteLine("");

                var keywords = enteredString.Split(' ');
                if (isValidEntry(keywords))
                {
                    switch (keywords[0])
                    {
                        case "ADD":
                            Console.WriteLine(_dictionaryApp.AddMember(keywords[1], keywords[2]));
                            break;
                        case "REMOVE":
                            Console.WriteLine(_dictionaryApp.RemoveMember(keywords[1], keywords[2]));
                            break;
                        case "MEMBEREXISTS":
                            Console.WriteLine(_dictionaryApp.MemberExists(keywords[1], keywords[2]));
                            break;
                        case "MEMBERS":
                            if (!multiValDictionary.ContainsKey(keywords[1]))
                            {
                                Console.WriteLine("ERROR, key does not exist.");
                            }
                            else
                            {
                                foreach (var item in _dictionaryApp.GetMembers(keywords[1]))
                                {
                                    Console.WriteLine(item);
                                }
                            }
                            break;
                        case "REMOVEALL":
                            Console.WriteLine(_dictionaryApp.RemoveAll(keywords[1]));
                            break;
                        case "KEYEXISTS":
                            Console.WriteLine(_dictionaryApp.KeyExists(keywords[1]));
                            break;
                        case "KEYS":
                            GetData(_dictionaryApp.GetKeys(keywords[0]));
                            break;
                        case "CLEAR":
                            Console.WriteLine(_dictionaryApp.Clear());
                            break;
                        case "ALLMEMBERS":
                            GetData(_dictionaryApp.GetAllMembers());
                            break;
                        case "ITEMS":
                            GetData(_dictionaryApp.GetItems());
                            break;
                        default:
                            break;
                    }
                }

            } while (!String.IsNullOrEmpty(enteredString));
             
        }

        private static void GetData(List<string> items)
        {            
            if (items.Count > 0)
            {
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("(empty set)");
            }
        }
        

        private static bool isValidEntry(string[] keywords)
        {         

            if (keywords[0] == "ADD" || keywords[0] == "REMOVE" || keywords[0] == "MEMBEREXISTS")
                return keywords.Length == 3;

            if (keywords[0] == "MEMBERS" || keywords[0] == "REMOVEALL" || keywords[0] == "KEYEXISTS")
                return keywords.Length == 2;

            if (keywords[0] == "KEYS" || keywords[0] == "CLEAR" || keywords[0] == "ALLMEMBERS" || keywords[0] == "ITEMS")
                return keywords.Length == 1;

            return false;
        }


        public string AddMember(string key, string value)
        {
            if (!multiValDictionary.ContainsKey(key))
            {
                multiValDictionary[key] = new List<string>() { value };
                return "Added";
            }
            else
            {
                if (!multiValDictionary[key].Contains(value)) {
                    multiValDictionary[key].Add(value);
                    return "Added";
                }
                else {
                    return "Error: member already exists for key";
                }

            }

        }

        public string Clear()
        {
            if(multiValDictionary.Count>0)
                multiValDictionary.Clear();

            return "Cleared";

        }

        public List<string> GetAllMembers()
        {
            List<string> lst = new List<string>();
            foreach (var item in multiValDictionary)
            {
                foreach (var ele in item.Value)
                {
                    lst.Add(ele);
                }
            }

            return lst;
        }

        public List<string> GetItems()
        {
            List<string> lst = new List<string>();
            foreach (var item in multiValDictionary)
            {
                foreach (var ele in item.Value)
                {
                    lst.Add(item.Key + ": " + ele);
                }
            }

            return lst;
        }

        public List<string> GetKeys(string key)
        {
            List<string> lst = new List<string>();
            foreach (var item in multiValDictionary)
            {
                lst.Add(item.Key);
            }

            return lst;
        }

        public List<string> GetMembers(string key)
        {         

            List<string> lst = new List<string>();
            foreach (var item in multiValDictionary[key])
            {
                lst.Add(item);
            }

            return lst;
        }

        public bool KeyExists(string key)
        {
            return multiValDictionary.ContainsKey(key);
        }

        public bool MemberExists(string key, string value)
        {
            if (!multiValDictionary.ContainsKey(key))
            {
                return false;
            }
            else
            {
                return multiValDictionary[key].Contains(value);            

            }
        }

        public string RemoveAll(string key)
        {
            if (!multiValDictionary.ContainsKey(key))
            {
                return "ERROR, key does not exists";
            }
            else
            {
                multiValDictionary.Remove(key);
                return "Removed";
            }
        }

        public string RemoveMember(string key, string value)
        {
            if (!multiValDictionary.ContainsKey(key))
            {
                return "ERROR, key does not exists";
            }
            else
            {
                if (!multiValDictionary[key].Contains(value))
                {
                    
                    return "ERROR, member does not exists";
                }
                else
                {
                    if (multiValDictionary[key].Count == 1)
                        multiValDictionary.Remove(key);
                    else
                        multiValDictionary[key].Remove(value);
                                        
                    
                    return "Removed";

                }
            }
        }
    }
}
