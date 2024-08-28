using System;
using System.Collections.Generic;

namespace SwinAdventure
{
    public class GameObject : IdentifiableObject
    {
        private readonly string _name;
        private readonly string _description;

        public GameObject(string[] ids,  string name, string desc) : base(ids)
        {
            _name = name;
            _description = desc;
        }


          public string Name => _name;

        public virtual string FullDescription => _description;
        public string ShortDescription => $"{_name} ({FirstId})";



    }









}