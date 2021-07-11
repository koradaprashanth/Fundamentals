using System.Collections.Generic;

namespace MultiValueDictionary
{
    interface IDictionaryApp
    {
        string AddMember(string key, string value);

        string RemoveMember(string key, string value);

        string Clear();

        bool KeyExists(string key);

        bool MemberExists(string key, string value);

        List<string> GetAllMembers();

        List<string> GetItems();

        string RemoveAll(string key);

        List<string> GetMembers(string key);

        List<string> GetKeys(string key);
        
    }
}
