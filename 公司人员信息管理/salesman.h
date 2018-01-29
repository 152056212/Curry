#pragma once
#include "employee.h"
#include<string>
#include <vector>
using namespace std;
class salesman :
	virtual public employee
{
public:
	string department;
	string number;
	string name;
	string sex;
	string level;
	float salary;
	salesman(int w_=0);
	~salesman(void);
	virtual int decide_w();
	virtual void v_salary();
	virtual void display();
	virtual void read();
    virtual void add();	  
    virtual bool modify();
    virtual bool del();
    virtual void save();
	virtual void print();
	friend  void fun_substr2(fstream &,string  ,vector <string> &);
	static int count_s;
protected:
	float sales;
	double commission;
	int w;
	string str_s2;
};

