using System;
using System.Collections.Generic;




namespace SwinAdventure
{
    public class IdentifiableObject
    {

        private List<string> _identifiers;

        public IdentifiableObject(string[] identifier)
        {

            _identifiers = new List<string>(identifier);

        }

        public bool AreYou(string id)
        {
            return _identifiers.Contains(id.ToLower());
        }


        public string FirstId
        {


            get { return _identifiers.Count > 0 ? _identifiers[0] : ""; }
        }


        public List<string> Identifiers
        {
            get { return _identifiers; }
        }

    }

}
