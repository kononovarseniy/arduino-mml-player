#include <Arduino.h>

#define SHARP 1
#define NORMAL 0
#define FLAT -1

double getNoteFrequency(char note, char modifier, char octave);
bool isNoteName(char note);
