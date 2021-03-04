# C# practice
* practice3-2 騎士走棋盤
  1. 在一個棋盤上從隨意一個起點開始
  2. 每次動作依照”馬”的移動方式
  3. 走過的地方不重複走
  4. 最後棋盤上每個點都走過一次
  ![image](https://user-images.githubusercontent.com/58549322/109910198-8aea5c00-7ce2-11eb-945f-dfbc471551d6.png)

  ->oucome:
  ![image](https://user-images.githubusercontent.com/58549322/109910264-ad7c7500-7ce2-11eb-820d-b62ab2b63a74.png)

  
* practice4-1 FGO-alike console program
  1. create character
  ![image](https://user-images.githubusercontent.com/58549322/109910582-6c389500-7ce3-11eb-9d33-dcba6b72757c.png)

  2. procedure
   -> Enter y to continue the game, n to end the game
   -> Create two object, player & enemy, both is random from 7 kinds of object
   -> Player and enemy attack each other
    > If one’s Random.nextDouble > hitRate, that one’s attack value count as 0
    > Else one’s attack value = attack * (strong or weak) * attackBuff
    
   -> Then show
    > Player & enemy’s type
    > Player & enemy’s health before attack
    > Player & enemy’s attack value
    > Player & enemy’s health after attack
 
  3. outcome
  ![image](https://user-images.githubusercontent.com/58549322/109910742-d18c8600-7ce3-11eb-94e4-2aace5f219e8.png)
  
* practice4-2 ATM
  1. an ATM Simulator that can withdraw NTD from the ATM
    ![image](https://user-images.githubusercontent.com/58549322/109914556-3b5c5e00-7ceb-11eb-84f8-2082c7bb849a.png)
    ![image](https://user-images.githubusercontent.com/58549322/109914580-47e0b680-7ceb-11eb-8ac9-a96965f75390.png)
    ![image](https://user-images.githubusercontent.com/58549322/109914601-53cc7880-7ceb-11eb-891f-4942f62bf94c.png)
    ![image](https://user-images.githubusercontent.com/58549322/109914621-5af38680-7ceb-11eb-8cde-27cead0afd06.png)


