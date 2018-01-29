#pragma once
#include<string>
#include<iostream>
using namespace std;
class employee
{
public:
	employee(void);
	~employee(void);
	virtual int decide_w()=0;
	virtual void display()=0;
	virtual void read()=0 ;
    virtual void add()=0;	  
    virtual bool modify()=0;
    virtual bool del()=0;
    virtual void save()=0;
	virtual void print()=0;
	virtual void v_salary()=0;
protected:
	string department;
	string number;
	string name;
	string sex;
	string level;
	float salary;
	
};

