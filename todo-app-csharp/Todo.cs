using System;

namespace todo_app_csharp
{
    class Todo
    {
        private string _title;
        private string _content;
        private int _memberID;
        private int _duration;

        private int _status;

        public Todo(string title, string content, int member_id, int duration, int status=0) {
            this._title = title;
            this._content = content;
            this._memberID = member_id;
            this._duration = duration;
            this._status = status;
        }

        public string GetTitle(){ return this._title;}
        public string GetContent(){ return this._content;} 
        public int GetMemberID(){ return this._memberID;}
        public string GetDuration(){
            string duration = 
                Enum.GetName(typeof(Todo_Duration.Duration), this._duration);
            return duration;
        }

        public void Set(string value) {
            this._title = value;
        }
        public void SetTitle(string value) {
            this._content = value;
        }public void SetContent(int value) {
            this._memberID = value;
        }public void SetMember(int value) {
            this._duration = value;
        }public void SetDuration(int value) {
            this._duration = value;
        }public void SetStatus(int value) {
            // 0: TODO  1: IN PROGRESS 2: DONE 
            if (value != 0 ||value != 1 || value != 2) { 
                throw new Exception("Todo durumu 0(TODO), 1(IN PROGRESS) ya da 2(DONE) olabilir.");
            }
            else { this._status = value; }
            
        }
        public void TodoDetails() {
            Console.WriteLine("Başlık      :" + GetTitle());
            Console.WriteLine("İçerik      :" + GetContent());
            Console.WriteLine("Atanan Kişi :" + (this._memberID).ToString() );
            Console.WriteLine("Büyüklük    :" + GetDuration() );  
        }
    }
}
