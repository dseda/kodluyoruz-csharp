using System;

namespace todo_app_csharp{
class Todo_Duration {
    public enum Duration {
    XS =1,
    S =2, 
    M=3, 
    L=4, 
    X=5,
    }

    public string getDuration(int id) {
        string duration = Duration.GetName(typeof(Duration), id);
        return duration;
    }
}
}