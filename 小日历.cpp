// 小日历.cpp : 定义控制台应用程序的入口点。
//


#include "stdafx.h"
#include <iomanip>
#include <ctime>
#include <iostream>
using namespace std;
void Showyear(int year)
{      int a[12]={31,28,31,30,31,30,31,31,30,31,30,31},b[12],r[6][14]={0},sum1=0,sum=0,count=0,m=1,n=1;
   if(year%400==0||(year%4==0)&&(year%100!=0))//求从1940到所输入的日期的相距天数
	               a[1]=a[1]+1;
   if(year>1940)
         { for(int i=1940;i<=year-1;i++)
          if((i%400==0)||(i%4==0)&&(i%100!=0))
	       ++count;//求从所输入的年的一月到所输入的月份之间天数；
            sum1=(year-1940-count)*365+count*366 ;}//所求天数与除本年之外的天数之和；
    for (int i=0;i<12;i++)
		   { for(int k=0;k<=i;k++)
	               {if(k==0)
				     sum=0;
				    else
					 sum=sum+a[k-1];}
	                if(6==(sum+sum1)%7)
			           b[i]=0;
		             else
	                   b[i]=((1+(sum+sum1)%7));
			           sum=0;
			}
    cout<<"|==================The Calendar Of Year "<<year<<" =====================|" <<endl;
	for(int j=0;j<6;j++)//循环输入
	       { cout<<"| "<<j+1<<"  SUN MON TUE WED THU FRI SAT"<<setw(4)<<j+7<<"  "<<"SUN MON TUE WED THU FRI SAT"<<" |"<<endl;
			 for (int i=0;i<6;i++)
	        for(int k=0;k<14;k++)
	              { //第一行
	                  if(i==0&&(k>=0&&k<b[j]||k>=7&&k<(b[j+6]+7)))
					       r[i][k]=0;
					  else//其余行
				       {if(k>=0&&k<=6)
					      {r[i][k]=m;m++;
					       if((m>a[j]+1))
					       r[i][k]=0;}
					    if(k>=7&&k<=13)
						  {r[i][k]=n;n++;
						  if(n>(a[j+6]+1))
						    r[i][k]=0;}}
			               
                 //循环输出
                   if(k==0)
						cout<<"|   ";
				  if(k==7)
					 cout<<"     ";
				   if(r[i][k]==0)cout<<"    ";
				   else 
					   cout<<setw(4)<<r[i][k];
				   if(k==13)cout<<" |"<<endl;
	           }n=1;m=1;
	       }
	cout<<"|=================================================================|"<<endl;
}
void Showmonth(int year,int month)//输出某月的日历的函数
{int sum=0,count=0;
 int a[12]={31,28,31,30,31,30,31,31,30,31,30,31};//一年每个月份；
 if(year%400==0||(year%4==0)&&(year%100!=0))
	 a[1]=a[1]+1;
 if(year>1940)
    {for(int i=1940;i<=year-1;i++)
      {if((i%400==0)||(i%4==0)&&(i%100!=0))
	  ++count;}
    for(int i=0;i<month-1;i++)
            sum=sum+a[i];//求从所输入的年的一月到所输入的月份之间天数；
	   sum=(year-1940-count)*365+count*366+sum;//所求天数与除本年之外的天数之和；
    }
 else
   {for(int i=0;i<month-1;i++) 
    sum=sum+a[i];
    }//若是1940年，就直接求；
 cout<<" SUN MON TUE WED THU FRI SAT"<<endl;
 int t=0,k=0;
 if (sum%7<6)
    { for (int i=0 ;i<1+sum%7 ;i++)
 {cout<<"    "; t++;}
    }//求所输入的月份的首天之前有几个空格；
 for(int i=1;i<=12;i++)
 {k++;
 if(month==i)
	 break;}
 for(int i=1;i<=a[k-1];i++)
 {  cout<<setw(4)<<i;t++;
 if(t%7==0)
	 cout<<endl;}//输出月历
 cout<<endl;
}
int Showday(int year,int month ,int day )//输出某个日期的信息的函数
  { int count,sum,m=0,n=0;
     count=sum=0;
	 tm*year1;
	 tm*month1;
	 tm*day1;
	 time_t t;
	 t=time(0);
	 year1=localtime(&t);
	 month1=localtime(&t);
	 day1=localtime(&t);
	 cout<<"month"<<  (month1->tm_mon+1)<<(day1->tm_mday)<<endl;
	 int a[12]={31,28,31,30,31,30,31,31,30,31,30,31};
	 if(year>(year1->tm_year+1900))//若所输入的日期在2015年之后；
	    { for(int i=(year1->tm_year+1900)+1;i<year;i++)
	      if((i%400==0)||(i%4==0)&&(i%100!=0))
			  count++;
	          sum=365*(year-1-(year1->tm_year+1900))+count;//计数从2015年到year之间的天数；
	      for(int i=1;i<month;i++)
			  m=m+a[i-1];//输入之年之内，输入之月之前的天数
		  for(int b=12;b>(month1->tm_mon+1);b--)
			  n=n+a[b-1];//本年内，本月之前的天数
		     sum=sum+n+a[(month1->tm_mon+1)-1]-(day1->tm_mday)+m+day;//总天数
	     }//计算天数；
	 
	 if (year==(year1->tm_year+1900))//本年情况下
	      { if ((month==(month1->tm_mon+1))&&day>=(day1->tm_mday))//本月内，且本天之后
	               sum=day-(day1->tm_mday);
		   else 
		       {if(month!=(month1->tm_mon+1))//不在同一月
			      {for (int i=month+1;i<(month1->tm_mon+1);i++)
		          sum=sum+a[i-1];
	              sum= a[month-1]-day+1+sum+(month1->tm_mon+1)-1;}
		        else //同一个月，但在本天之前
                  sum=(day1->tm_mday)-day;
	           }
	       }
	 if (year<(year1->tm_year+1900))//本年之前
	    {  for(int i=(year1->tm_year+1900)-1;i>year;i--)  
	              count++;//闰年数
	              sum=365*((year1->tm_year+1900)-year-1)+count;//计天数（输入之年与本年之间）
		   for(int i=1;i<(month1->tm_mon+1);i++)
				  m=m+a[i-1];//本年内，本月之前的天数
		   for(int b=12;b>month;b--)
			      n=n+a[b-1];//输入之年之内，输入之月之后的天数
			      sum=sum+m+(day1->tm_mday)-1+n+a[month-1]-day+1;//总天数
	    }
	 cout<<"您输入的日期距今有"<<sum<<"天。"<<endl;//相距天数
  int sum1=count=0;
  if(year%400==0||(year%4==0)&&(year%100!=0))//求从1940到所输入的日期的相距天数
	               a[1]=a[1]+1;
  if(year>1940)
     { for(int i=1940;i<=year-1;i++)
        {if((i%400==0)||(i%4==0)&&(i%100!=0))
	      ++count;}
       for(int i=0;i<month-1;i++)
          sum1=sum1+a[i];//求从所输入的年的一月到所输入的月份之间天数；
	      sum1=(year-1940-count)*365+count*366+sum1;//所求天数与除本年之外的天数之和；
     }
  else
       { for(int i=0;i<month-1;i++) 
         sum1=sum1+a[i];}
         sum1=sum1+day-1;
	    //若是1940年，就直接求；
  if (sum1%7<6)
	      cout<<"所输入的日期是星期"<<1+sum1%7<<endl;
  else
		  cout<<"星期日"<<endl;
  switch(month)
	 { case 1:if(day==1){cout<<"YES，元旦"<<endl;break;}
	           else 
			      {cout<<"您所输日期不是公历节日。"<<endl;break;} 
	   case 2:if(day==14){cout<<"YES,情人节"<<endl;break;}
			  else 
			      {cout<<"您所输日期不是公历节日。"<<endl;break;}
	   case 3:if(day==12){cout<<"YES，植树节"<<endl;break;}
			  else 
			      {cout<<"您所输日期不是公历节日。"<<endl;break;}
	   case 4:if (day==1){cout<<"YES,愚人节"<<endl;break;}
		   else 
			      {cout<<"您所输日期不是公历节日。"<<endl;break;}
	   case 5:if (day==1)
			     {cout<<"YES,劳动节"<<endl;break;}
			  else 
			      {   if (day==4)
			            {cout<<"YES,青年节"<<endl;break;}
			          else
			              {if (sum1%7==6&&day>=8)
			             {cout<<"YES，母亲节"<<endl;break;}
			              else 
			                {cout<<"您所输日期不是公历节日。"<<endl;break;}}
	   case 6:if (day==1)
			  {cout<<"YES，儿童节"<<endl;break;}
			  else
			      {if(sum1%7==6&&day>=15)
			       {cout<<"YES，父亲节"<<endl;break;}
			       else 
			      {cout<<"您所输日期不是公历节日。"<<endl;break;}
			  }
	   case 7:if(day==1)
			  {cout<<"建党节"<<endl;break;}
			  else 
			      {cout<<"您所输日期不是公历节日。"<<endl;break;}
	   case 8:if(day==1)
			  {cout<<"建军节"<<endl;break;}
			  else 
			      {cout<<"您所输日期不是公历节日。"<<endl;break;}
	   case 9:if(day==10)
			  {cout<<"YES,教师节"<<endl;break;}
			  else
				  {if(year>=2015&&day==13)
			     {cout<<"YES,抗战胜利日"<<endl;break;}  
			            else 
			      cout<<"您所输日期不是公历节日。"<<endl;break;}
	   case 10:if (day==1)
			   {cout<<"YES,国庆节"<<endl;break;}
	   case 12:if (day==13&&year>=2014)
			      {cout<<"YES,南京大屠杀日"<<endl;break;}  
			   else 
			      {cout<<"您所输日期不是公历节日。"<<endl;break;}

	   default:cout<<"您所输日期不是公历节日。"<<endl;
				   
			  }  }  return sum1;cout<<endl;}
int _tmain(int argc, _TCHAR* argv[])
{   int number,year,month,day;
   while(1)
	{cout<<"您想得到某年的日历的话，请按1键；您想得到某年某月的日历，请按2键；您想得到某日的信息，请按3键;若想停止，请按4(若输入格式错误，须重新输入)。";
    cin>>number;
	switch (number)
		{case 1:do
				{cout<<"请输入您要知道的某年（若格式输入错误，系统会要求您再次输入）：";
					cin>>year; }while(year<1940||year>2040);
					Showyear(year);break;
		case 2: do
				{cout<<"请输入您要知道的某年某月（若格式输入错误，系统会要求您再次输入）：";
					cin>>year>>month; }while(year<1940||year>2040 ||month<=0||month>=13);
					Showmonth(year,month);break;
	    case 3: do
				{ cout<<"请输入您要知道的某年某月某日（若格式输入错误，系统会要求您再次输入）：";
				cin>>year>>month>>day;
				}while(year<1940||year>2040 ||month<=0||month>=13||day<=0||day>32);
				Showday(year,month,day);break;}
      if(number==4)
         break;}
	return 0;
}
