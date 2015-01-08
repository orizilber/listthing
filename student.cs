private string _name;
private int _idNum;
private int _year;

public int name(string name)
{
    get{return this._name;}
    set{this._name = name;}
}
public int idNum(int idNum)
{
    get{return this._idNum;}
    set{this._idNum = idNum;}
}
public int year(int year)
{
    get{return this._year;}
    set{this._year = year;}
}

public student (string name, int idNum, int year)
{
    this._name = name;
    this._idNum = idNum;
    this._year = year;
}