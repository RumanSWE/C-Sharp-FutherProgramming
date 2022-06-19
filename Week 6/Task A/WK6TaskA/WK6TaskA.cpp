// Pointers.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

void substitute(string* s, char c1, char c2);

int main()
{
	string* ptrString;
	string temp;

	char in1, in2;
	cout << "enter string" << endl;
	cin >> temp;
	cout << "Enter character to be replaced" << endl;
	cin >> in1;
	cout << "Enter character to replace with" << endl;
	cin >> in2;

	ptrString = &temp;
	substitute(ptrString, in1, in2);
}
void substitute(string* s, char c1, char c2)
{
	//int t = s->length();
	
	for (char const& x : *s) 
	{
		if (x == c1)
		{
			cout << c2;
			
			
		}
		else
		{
			cout << x;
		}
	}
}

