using System.Collections.Generic;

namespace QLBH_BunifuUI.Common
{
    public class Session
    {
        private static Dictionary<string, object> _listObject;
        public void Add(string key, object value)
        {
            if (_listObject.ContainsKey(key))
                _listObject[key] = value;
            else
                _listObject.Add(key, value);
        }

        private static Session _instance;

        public static Session Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Session();
                }
                return _instance;
            }
        }

        private Session()
        {
            if(_listObject == null)
                _listObject = new Dictionary<string, object>();
        }


        public object Get(string key)
        {
            if (_listObject.ContainsKey(key))
                return _listObject[key];
            else
                return null;
        }

        public object this[string key] { set { Add(key, value); } get { return Get(key); } }

        public void Clear()
        {
            _listObject.Clear();
        }
    }
}
