#include "Music.h"

#define ERROR_NOTE -32768
const char *noteNames = "CDEFGAB";
//                             до ре ми фа соль ля си
//                              C  D  E  F  G  A  B
const int noteToneIndices[] = { 0, 2, 4, 5, 7, 9, 11 };

int getToneIndex(char note, int halfTone, int octave) {
    const char *ptr = strchr(noteNames, toupper(note));
    if (ptr == NULL) return ERROR_NOTE;
    int ind = ptr - noteNames;
    return octave * 12 + noteToneIndices[ind] + halfTone;
}

const double halfTone = pow(2, 1.0 / 12);
const double baseFrequency = 440;
const double baseTone = getToneIndex('A', 0, 4);

double getNoteFrequency(char note, char modifier, char octave)
{
  int toneInd = getToneIndex(note, modifier, octave);
  if (toneInd == ERROR_NOTE) return -1;
  return baseFrequency * pow(halfTone, toneInd - baseTone);
}

bool isNoteName(char note) {
  return strchr(noteNames, toupper(note)) != NULL;
}

