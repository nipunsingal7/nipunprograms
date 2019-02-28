#include<stdio.h>                              /*made by nipun singal himself*/

int main ()
{                                             /*declaring the variables*/
    int [20];                                  /*array is declared*/
    char ans,ans2;
    char name[20];
    int i=0,b;
printf("                  ***********Welcome to the C language Quiz****************\n");            /*program begins*/
printf("\n        Round1                     Round2                         Round3\n");
printf("       True/False (Q1-Q10)    Multiple Choice(Q11-Q15)       Multiple answers(Q16-Q20)\n");
printf("\n  ****Total marks=20****\n   Their is negative marking\n\n\n\n");
printf("Candidate name-");
scanf("%s",name);
printf("\n\n");
printf("Lets start the quiz\n\n");

for(a=0;a<=100;a++)                                /*for loop is used so that we can go to any question anytime*/
{         if(c==0)                                     /*if user enters 0 program comes out of loop and shows score*/
           {break;}
             printf("enter the question number you want to go or enter 0 to end the quiz:");
             scanf("%d",&i);

                  switch(i)                           /*switch case starts,it contains the quiz questions*/

                  {

                    case 1:printf("\nRound1 Begins.......Write T/F\n\n");
                     printf("Q1. C language is developed by Dennis M. Ritchie?\n answer--");
                     scanf("%s",&ans);                             /*this will store the users answer*/
                     if(ans=='T'||ans=='t')
                     {scr[0]=1;}                       /*if users answer is correct it will store 1 in the scr array*/
                     else                               /*otherwise zero in scr array*/
                     {scr[0]=-1;}
                     printf("\n\n");
                     break;

               case 2:printf("\nQ2. A function cannot be defined inside another function?\n answer--");
                     scanf("%s",&ans);
                     if(ans=='T'||ans=='t')
                     {scr[1]=1;}
                     else
                     {scr[1]=-1;}
                     printf("\n\n");
                     break;

              case 3:printf("\nQ3. The ++ operator increments the operand by 1, whereas, the -- operator decrements it by 1?\n answer--");
                     scanf("%s",&ans);
                     if(ans=='T'||ans=='t')

                     break;

              case 4:printf("\nQ4. Functions cannot return more than one value at a time?\n answer--");
                     scanf("%s",&ans);
                     if(ans=='T'||ans=='t')
                     {scr[3]=1;}
                     else
                     {scr[3]=-1;}
                     printf("\n\n");
                     break;

            case 5:printf("\nQ5. The keywords cannot be used as variable names?\n answer--");
                     scanf("%s",&ans);
                     if(ans=='T'||ans=='t')
                     {scr[4]=1;}
                     else
                     {scr[4]=-1;}
                     printf("\n\n");
                     break;

              case 6:printf("\nQ6. Continue keyword skip one iteration of loop?\n answer--");
                     scanf("%s",&ans);
                     if(ans=='T'||ans=='t')
                     {scr[5]=1;}
                     else
                     {scr[5]=-1;}
                     printf("\n\n");
                     break;


               case 7:printf("\nQ7. Switch statement can have any number of case instances?\n answer--");
                     scanf("%s",&ans);
                     if(ans=='T'||ans=='t')
                     {scr[6]=1;}
                     else
                     {scr[6]=-1;}
                     printf("\n\n");
                     break;

               case 8:printf("\nQ8. Sizes of an integer and a pointer must be same?\n answer--");
                     scanf("%s",&ans);
                     if(ans=='F'||ans=='f')
                     {scr[7]=1;}
                     else
                     {scr[7]=-1;}
                     printf("\n\n");
                     break;


                 case 9:printf("\nQ9. Functions can be called either by value or reference?\n answer--");
                     scanf("%s",&ans);
                     if(ans=='T'||ans=='t')
                     {scr[8]=1;}
                     else
                     {scr[8]=-1;}
                     printf("\n\n");
                     break;



                case 10:printf("\nQ10. If return type for a function is not specified, it defaults to int?\n answer--");
                     scanf("%s",&ans);
                     if(ans=='T'||ans=='t')
                     {scr[9]=1;}
                     else
                     {scr[9]=-1;}
                     printf("\n\n");
                     break;

                case 11:printf("\nRound2 Begins......Multiple Choice  Write A,B,C or D\n\n\n");
                        printf("Q11. How to round-off a value 5.77 to 6.0?\n (A) ceil(5.77)\n (B) round-off(5.77)\n (C) round-up(5.77)\n (D) floor(5.77)\n\n answer--");
                        scanf("%s",&ans);
                        if(ans=='A'||ans=='a')
                        {scr[10]=1;}
                         else
                        {scr[10]=1;}
                         printf("\n\n");
                         break;

                case 12:printf("\nQ12. Set of consecutive memory locations is called as ________?\n (A) Function\n (B) Loop\n (C) Array\n (D) Pointer\n\n answer--");
                     scanf("%s",&ans);
                     if(ans=='C'||ans=='c')
                     {scr[11]=1;}
                     else
                     {scr[11]=-1;}
                     printf("\n\n");
                     break;

                 case 13:printf("\nQ13. If you pass an array as an argument to a function, what actually gets passed?\n (A) First element of the array\n (B) Value of elements in array\n (C) Address of the last element of array\n (D) Base address of the array\n\n answer--");
                     scanf("%s",&ans);
                     if(ans=='D'||ans=='d')
                     {scr[12]=1;}
                     else
                     {scr[12]=-1;}
                     printf("\n\n");
                     break;

                  case 14:printf("\nQ14. The keyword used to transfer control from a function back to the calling function is?\n (A) Switch\n (B) Goto\n (C) Go back\n (D) Return\n\n answer--");
                     scanf("%s",&ans);
                     if(ans=='D'||ans=='d')
                     {scr[13]=1;}
                     else
                     {scr[13]=-1;}
                     printf("\n\n");
                     break;


                 case 15:printf("\nQ15. C is the successor of ___ programming language?\n (A) C++\n (B) B++\n (C) B\n (D) Mini C\n\n answer--");
                     scanf("%s",&ans);
                     if(ans=='C'||ans=='c')
                     {scr[14]=1;}
                     else
                     {scr[14]=-1;}
                     printf("\n\n");
                     break;


                 case 16:printf("\nRound3 Begins.......Multiple answers   Write A,B,C or D\n\n");
                         printf("Q16. Which of the following are bitwise operators?\n (A) &\n (B) |\n (C) ^\n (D) +\n\n answer--");
                         scanf("%s%s%s",&ans,&ans1,&ans2);
                         if((ans=='A'&&ans1=='B'&&ans2=='C')||(ans=='a'&&ans1=='b'&&ans2=='c'))
                         {scr[15]=1;}
                         else
                        {scr[15]=-1;}
                        printf("\n\n");
                        break;

                  case 17:printf("\nQ17. Which of the following are loops?\n (A) for\n (B) while\n (C) switch case\n (D) If-else\n\n answer--");
                     scanf("%s%s",&ans,&ans1);
                     if((ans=='A'&&ans1=='B')||(ans=='a'&&ans1=='b'))
                     {scr[16]=1;}
                     else
                     {scr[16]=-1;}
                     printf("\n\n");
                     break;

                  }

}                                                     /*program ends*/


