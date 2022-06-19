// wk6TaskBs.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
void recombination(string s1, string s2, string s3);

class split {
public:
    string left;
    string right;


};

int main()
{
    recombination("AGCGAGCA", "TAGCTTGCGAT", "GC");
}
void recombination(string s1, string s2, string s3) {

    size_t pos = 0;
    string token;

    while ((pos = s1.find(s3)) != string::npos) 
    {
        token = s1.substr(0, pos);
        cout << token << endl;
        s1.erase(0, pos + s3.length());

        while ((pos = s2.find(s3)) != std::string::npos) 
        {
            token = s2.substr(0, pos);
            std::cout << token << std::endl;
            s2.erase(0, pos + s3.length());
        }
    }
    cout << s1;
    cout << s2;
    //cout << s3;
}