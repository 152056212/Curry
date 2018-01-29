#pragma once
#include"employee.h"
#include"manager.h"
#include"salesman.h"
#include<string>
#include <vector>
using namespace std;
class salesmanager:
	public salesman,public manager
{
public:
	string department;
	string number;
	string name;
	string sex;
	string level;
	float salary;
	salesmanager(int w_=0);
	~salesmanager(void);
	virtual int decide_w();
	virtual void v_salary();
	virtual void display();
	virtual void read();
    virtual void add();	  
    virtual bool modify();
    virtual bool del();
    virtual void save();
	virtual void print();
	friend  void fun_substr4(fstream &,string  ,vector <string> &);
	static int count_s_m;
private:
	int w;
	string str_s4;
};

