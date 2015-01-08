private int _courseName;
private int _grade;

public int courseName(int courseName)
{
    get{return this._courseName;}
    set{this._courseName = courseName;}
}
public int grade(int grade)
{
    get{return this._grade;}
    set{this._grade = grade;}
}

public grade(int courseName, int grade)
{
    this._courseName = courseName;
    this._grade = grade;
}