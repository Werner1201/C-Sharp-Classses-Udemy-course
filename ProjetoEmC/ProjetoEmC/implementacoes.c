#include<string.h>

extern const char* diz_nome(const char nome[]){
    char greeting[200] = "";
    char firstpart[] = "Seja Bem-vindo(a) ";
    char lastpart[] = " é um prazer recebê-lo(a).\n";
    strcat(greeting, firstpart);
    strcat(greeting, nome);
    strcat(greeting, lastpart);
    return greeting;
}