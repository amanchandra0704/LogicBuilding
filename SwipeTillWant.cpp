#include <iostream>
#include <cmath>

using namespace std;

// this code swipes the given integer value stored in two variable till you want to continue swiping or not

int main() {
    
    int num1;
    int num2;
    string confirmation;

    for (int i = 0; ; i++)
    {
        cout << "Do you want to continue swiping int values? yes or no : ";
        cin >> confirmation;

        if (confirmation == "no")
        {
            break;
        }
        else if (confirmation == "yes")
        {
            cout << "Enter num1 : ";
            cin >> num1;
            cout << "Enter num2 : ";
            cin >> num2;

            cout << "\n\nbefore swiping\n" << "num 1 : " << num1 << "\nnum2 : " << num2;

            num2 = num2 - num1;
            num1 = num1 + num2;
            num2 = num1 - num2;

            cout << "\n\nafter swiping\n" << "num 1 : " << num1 << "\nnum2 : " << num2 << "\n\n\n";

        }
        else {
            cout << "your respond is not valid, enter a valid response\n\n";
        }
        
    }
    return 0;
}