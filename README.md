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

* practice5-1 DIY Pizza
  1. 使用RatioButton實現Pizza醬料選擇(3種醬料+不加醬)
  2. 使用CheckBox + TextBox實現配料選擇(2種配料)
  3. 配料Random到醬料上(醬料和配料皆不可”飛出”餅皮外)
  4. 按下Button後生成對應的Pizza
  5. 需可重複生成
  6. 醬料需要可以換，配料往上加即可
  7. 例如：
    ![image](https://user-images.githubusercontent.com/58549322/109915008-0dc3e480-7cec-11eb-89d0-9bd927a21d5b.png)
  
* practice5-2 工具人的工具
  1. 使用TabControl區分 色碼電阻表&串聯/並聯計算
  2. 使用RatioButton實現顏色選擇，同時計算電阻值
  3. 計算結果用TextBox顯示，並且ReadOnly = True
  4. 例如：
    ![image](https://user-images.githubusercontent.com/58549322/109915233-6b583100-7cec-11eb-9d30-ba655d430c0a.png)

  
* practice5-2

