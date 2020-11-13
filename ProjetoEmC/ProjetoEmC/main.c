#include<stdio.h>
#include<string.h>
#include"implementacoes.h"
#include<locale.h>



void main() {
	printf("Hello World\n");
	printf("Digite seu Nome: ");
	char nome[100] = "";

	scanf("%s", nome);
	char greet[200] = "";
	strcat(greet, diz_nome(nome));
	printf("\n%s", greet);
	return 0;
}