// keystroke.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <Windows.h>

using namespace std;


int main()
{
	INPUT ip;
	
	ip.type = INPUT_KEYBOARD;
	
	system("pause");
	while (true) {
		ip.type = INPUT_KEYBOARD;
		ip.ki.wScan = 0;
		ip.ki.time = 0;
		ip.ki.dwExtraInfo = 0;
		ip.ki.wVk = 0x57;
		ip.ki.dwFlags = 0;
		SendInput(1, &ip, sizeof(INPUT));
		Sleep(5);
		ip.ki.dwFlags = KEYEVENTF_KEYUP;
		SendInput(1, &ip, sizeof(INPUT));
		
	}
    return 0;
}

