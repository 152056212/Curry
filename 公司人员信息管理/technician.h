#pragma once
#include "employee.h"
#include<string>
#include <vector>
using namespace std;
class technician :
	public employee
{
public:
	string department;
	string number;
	string name;
	string sex;
	string level;
	float salary;
	technician(int w_=0);
	~technician(void);
	virtual int decide_w();
	virtual void v_salary();
	virtual void display();
	virtual void read();
    virtual void add();	  
    virtual bool modify();
    virtual bool del();
    virtual void save();
	virtual void print();
	friend  void fun_substr1(fstream &,string  ,vector <string> &);
	static int count_t;
private:
	float hour;
	float hoursalary;
	int w;
	string str_s1;
};

