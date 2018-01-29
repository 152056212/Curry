#pragma once
#include<string>
#include"employee.h"
#include <vector>
using namespace std;
class manager :
	virtual public employee
{
public:
	string department;
	string number;
	string name;
	string sex;
	string level;
	float salary;
	manager(int w_=0);
	~manager(void);
	virtual int decide_w();
	virtual void v_salary();
	virtual void display();
	virtual void read();
    virtual void add();	  
    virtual bool modify();
    virtual bool del();
    virtual void save();
	virtual void print();
	friend  void fun_substr3(fstream &,string  ,vector <string> &);
	static int count_m;
protected:
	float fixsalary;
	int w;
	string str_s3;
};

