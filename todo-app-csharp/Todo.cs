using System;

namespace todo_app_csharp
{
    class Todo
    {
        private string _title;
        private string _content;
        private int _memberID;

        private int _duration;

        //(int)Members.Seda
        // returns 1

        public string GetTitle(){ return this._title;}
        public string GetContent(){ return this._content;} 
        public int GetMemberID(){ return this._memberID;}
        public string GetDuration(){ 
            return findDuration(this._duration);
        }

        public string findDuration(int id){
            string duration = 
                Enum.GetName(typeof(Todo_Duration.Duration), id);
            return duration;
        }
    }
}
