## 1.Exercises: C# Basics – More Exercises

Problems for exercises and homework for the [&quot;Programming Fundamentals Extended&quot; course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

1. Problem 1.X

Write a program, which **prints** an **X figure** with height **n**.

**N** will be an **odd number** in the range **[3…99]**.

### Examples

| **Input** | **Output** |   | **Input** | **Output** |   | **Input** | **Output** |
| --- | --- | --- | --- | --- | --- | --- | --- |
| 3 | x x xx x | 5 | x   x x x  x x xx   x | 11 | x         x x       x  x     x   x   x    x x     x    x x   x   x  x     x x       xx         x |

1. Problem 2.Vapor Store

After the previous problem, you feel like taking a break, so you go on the **Vapor Store** to buy some video games. Write a program, whichhelps you buy the games. The **valid games** are the following games in this table:

| **Name** | **Price** |
| --- | --- |
| OutFall 4 | $39.99 |
| CS: OG | $15.99 |
| Zplinter Zell | $19.99 |
| Honored 2 | $59.99 |
| RoverWatch | $29.99 |
| RoverWatch Origins Edition | $39.99 |

On the first line, you will receive your **current balance** – a **floating-point** number in the range **[0.00…5000.00]**.

Until you receive the command &quot; **Game Time**&quot;, you have to keep **buying games**. When a **game** is **bought** , the user&#39;s **balance** decreases by the **price** of the game.

Additionally, the program should obey the following conditions:

- If a game the user is trying to buy is **not present** in the table above, print &quot; **Not Found**&quot; and **read the next line**.
- If at any point, the user has **$0** left, print &quot; **Out of money!**&quot; and **end the program**.
- Alternatively, if the user is trying to buy a game which they **can&#39;t afford** , print &quot; **Too Expensive**&quot; and **read the next line**.

When you receive &quot; **Game Time**&quot;, **print** the user&#39;s **remaining money** and **total spent on games** , **rounded** to the **2**

# nd
 **decimal place**.
### Examples

| **Input** | **Output** |
| --- | --- |
| 120RoverWatchHonored 2Game Time | Bought RoverWatchBought Honored 2Total spent: $89.98. Remaining: $30.02 |

| **Input** | **Output** |
| --- | --- |
| 19.99Reimen originRoverWatchZplinter ZellGame Time | Not FoundToo ExpensiveBought Zplinter ZellOut of money! |

| **Input** | **Output** |
| --- | --- |
| 79.99OutFall 4RoverWatch Origins EditionGame Time | Bought OutFall 4Bought RoverWatch Origins EditionTotal spent: $79.98. Remaining: $0.01 |

1. Problem 3.Megapixels

Write a program, which, given an **image resolution** ( **width** and **height** ), calculates its **megapixels**. **Megapixels** (short for **millions of pixels** ) are calculated by **counting** all the **image**** pixels **, then** dividing **the result by** 1000000**.

The megapixels must **always** be rounded to the **first digit** after the **decimal point** (i.e. 0.786 MP  0.8MP).

### Input

- **First Line** – the **width** of the image – integer in range **[1…20000]**
- **Second Line** – the **height** of the image – integer in range **[1…20000]**

### Examples

| **Input** | **Output** |   | **Input** | **Output** |   | **Input** | **Output** |
| --- | --- | --- | --- | --- | --- | --- | --- |
| 1024768 | 1024x768 =\&gt; 0.8MP | 19201080 | 1920x1080 =\&gt; 2.1MP | 53443006 | 5344x3006 =\&gt; 16.1MP |

### Hints

- To round a number, you can use the [Round()](https://msdn.microsoft.com/en-us/library/75ks3aby(v=vs.110).aspx) method.

1. Problem 4.Photo Gallery

Write a program, which receives **image metadata** as input and prints information about the image, such as its **filename** , **date taken** , **size** , **resolution** and **aspect ratio**. Also, calculate the **orientation** of the image. The **3** orientations are: **portrait** , **landscape** and **square**.

### Input

- **First line** – the photo&#39;s **number** – an **integer** in the range **[0…9999]**
- **Second, third, fourth line** – the **day** , **month** and **year** the photo was taken – **integers** forming **valid** dates in the range **[01/01/1990…31/12/2020]**
- **Fifth, sixth line** – the **hours** and **minutes** the photo was taken – **integers** in the range **[0…23]**
- **Seventh line** – the photo&#39;s **size** in **bytes** – **integer** in the range **[0…999000000]**
- **Eighth, ninth line** – the photo&#39;s **resolution** ( **width** and **height** )in **pixels** – **integers** in the range **[1…10000]**

### Output

- The **name** should be printed in the format &quot; **DSC\_xxxx.jpg**&quot;.
- The **date and time taken** should be printed in the format &quot; **dd/mm/yyyy hh:mm**&quot;.
- The **size** should be printed in standard **human-readable** format (i.e. 950 bytes = 950B, 500000 bytes = 500KB, 1500000 bytes = 1.5MB).
- The **resolution** should be printed in the following format: &quot; **{width}x{height}**&quot;.
- The **orientation** can be one of three valid values: **portrait** , **landscape** and **square**.

### Examples

| **Input** | **Output** |   | **Input** | **Output** |
| --- | --- | --- | --- | --- |
| 3525122003123150000053343006 | Name: DSC\_0035.jpgDate Taken: 25/12/2003 12:03Size: 1.5MBResolution: 5334x3006 (landscape) | 533203199311333500007681024 | Name: DSC\_0533.jpgDate Taken: 20/03/1993 11:33Size: 350KBResolution: 768x1024 (portrait) |

| **Input** | **Output** |
| --- | --- |
| 655212112012153385010001000 | Name: DSC\_6552.jpgDate Taken: 12/11/2012 15:33Size: 850BResolution: 1000x1000 (square) |

1. Problem 5.BPM Counter

Write a program, which receives **BPM** (beats per minute) and **number of beats** from the console and calculates how many **bars** (1 bar == 4 beats) the beats equal to, then calculates the **length** of the sequence in **minutes** and **seconds**.

The bars must **always** be rounded to the **first digit** after the **decimal point** (i.e. 1.75 bars  1.8 bars).

### Examples

| **Input** | **Output** |   | **Input** | **Output** |   | **Input** | **Output** |
| --- | --- | --- | --- | --- | --- | --- | --- |
| 6060 | 15 bars - 1m 0s | 12885 | 21.2 bars - 0m 39s | 52280 | 20 bars - 0m 9s |

1. Problem 6.DNA Sequences

You are a molecular biologist, who&#39;s on the verge of figuring out gene manipulation. But first you need to see what DNA sequences you&#39;re working with, so you decide to write a program to do it for you.

Write a program, which prints all the possible **nucleic acid sequences** ( **A** , **C** , **G** and **T** ), in the **range** [**AAA…TTT**]. **Each** nucleic acid sequence is exactly **3 nucleotides (letters) long**. Print a **new line** every **4** sequences.

Each nucleotide has a corresponding numeric value – A  1, C  2, G  3, T  4.

For every sequence, take the **sum** of its elements (e.g. **ACAC**  1 + 2 + 1 + 2 = 6) and if it&#39;s **equal to or larger than** the **match sum** , print the sequence with an &quot; **O**&quot; before and after it, otherwise print &quot; **X**&quot; before and after it.

### Examples

| **Input** | **Output** |   | **Input** | **Output** | **Comments** |
| --- | --- | --- | --- | --- | --- |
| 5 | XAAAX XAACX OAAGO OAATOXACAX OACCO OACGO OACTOOAGAO OAGCO OAGGO OAGTOOATAO OATCO OATGO OATTOXCAAX OCACO OCAGO OCATOOCCAO OCCCO OCCGO OCCTOOCGAO OCGCO OCGGO OCGTOOCTAO OCTCO OCTGO OCTTOOGAAO OGACO OGAGO OGATOOGCAO OGCCO OGCGO OGCTOOGGAO OGGCO OGGGO OGGTOOGTAO OGTCO OGTGO OGTTOOTAAO OTACO OTAGO OTATOOTCAO OTCCO OTCGO OTCTOOTGAO OTGCO OTGGO OTGTOOTTAO OTTCO OTTGO OTTTO | 11 | XAAAX XAACX XAAGX XAATXXACAX XACCX XACGX XACTXXAGAX XAGCX XAGGX XAGTXXATAX XATCX XATGX XATTXXCAAX XCACX XCAGX XCATXXCCAX XCCCX XCCGX XCCTXXCGAX XCGCX XCGGX XCGTXXCTAX XCTCX XCTGX XCTTXXGAAX XGACX XGAGX XGATXXGCAX XGCCX XGCGX XGCTXXGGAX XGGCX XGGGX XGGTXXGTAX XGTCX XGTGX OGTTOXTAAX XTACX XTAGX XTATXXTCAX XTCCX XTCGX XTCTXXTGAX XTGCX XTGGX OTGTOXTTAX XTTCX OTTGO OTTTO | Combinations, where &quot;sum \&gt;= 11&quot;:GTT  3+4+4  11TGT  4+3+4  11TTG  4+4+3  11TTT  4+4+4  12 |

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 10 | XAAAX XAACX XAAGX XAATXXACAX XACCX XACGX XACTXXAGAX XAGCX XAGGX XAGTXXATAX XATCX XATGX XATTXXCAAX XCACX XCAGX XCATXXCCAX XCCCX XCCGX XCCTXXCGAX XCGCX XCGGX XCGTXXCTAX XCTCX XCTGX OCTTOXGAAX XGACX XGAGX XGATXXGCAX XGCCX XGCGX XGCTXXGGAX XGGCX XGGGX OGGTOXGTAX XGTCX OGTGO OGTTOXTAAX XTACX XTAGX XTATXXTCAX XTCCX XTCGX OTCTOXTGAX XTGCX OTGGO OTGTOXTTAX OTTCO OTTGO OTTTO | Combinations, where &quot;sum \&gt;= 10&quot;:CTT  2+4+4  10GGT  3+3+4  10GTG  3+4+3  10GTT  3+4+4  11TCT  4+2+4  10TGG  4+3+3  10TGT  4+3+4  11TTC  4+4+2  10TTG  4+4+3  11TTT  4+4+4  12 |

1. Problem 7.Training Hall Equipment

As the new intern in SoftUni, you&#39;re tasked with **equipping** the **new training halls** with all the **necessary items** to lead quality technical trainings. You&#39;ll be given a **budget** and a **list of items** to buy. The other intern will be tasked with plugging in everything and hopefully not getting anyone electrocuted in the process…

### Input

- On the first line, you will receive your **budget** – a floating-point value in the range **[0…1000000]**
- On the second line, you will receive the **number of items** you need to buy – an integer in the range **[0…10]**
- On the next **count\*3** lines, you will receive the **item data** as such:
  1. The **item**** name **–** string**
  2. The **item price** – **floating-point** value in the range **[0.50…1000.00]**
  3. The **item count** – **integer** in the range **[0…1000]**

### Output

Every time an item is **added** to the cart, print &quot; **Adding {count} {item} to cart.**&quot; on the console. Make sure to **pluralize** item names (if the **item**** count ****isn&#39;t 1** , add an **S** at the end of the item name). After all of the items have been added to the **cart** , you need to calculate the **subtotal** of the items and check if the **budget** will be **enough**.

- If it&#39;s enough, print &quot; **Money left: ${moneyLeft}**&quot;, **formatted** to the **2**
# nd
 **decimal point**.
- Otherwise, print &quot; **Not enough. We need ${moneyNeeded} more.**&quot;, **formatted** to the **2**
# nd
 **decimal point**.

### Examples

| **Input** | **Output** |   | **Input** | **Output** |
| --- | --- | --- | --- | --- |
| 200004projector299.992hdmi cable4.991chair19.99180desk199.9960 | Adding 2 projectors to cart.Adding 1 hdmi cable to cart.Adding 180 chairs to cart.Adding 60 desks to cart.Subtotal: $16202.57Money left: $3797.43 | 7003projector399.991hdmi cable6.993chair2.9980desk99.9925 | Adding 1 projector to cart.Adding 3 hdmi cables to cart.Adding 80 chairs to cart.Subtotal: $660.16Money left: $39.84 |

| **Input** | **Output** |
| --- | --- |
| 20004whiteboard1501marker6.9910chalk0.5020beanbag chair119.9915 | Adding 1 whiteboard to cart.Adding 10 markers to cart.Adding 20 chalks to cart.Adding 15 beanbag chairs to cart.Subtotal: $2029.75Not enough. We need $29.75 more. |

1. Problem 8.\* SMS Typing

Write a program, which emulates **typing an SMS** , following this guide:

| **1** | **2** abc | **3** def |
| --- | --- | --- |
| **4** ghi | **5** jkl | **6** mno |
| **7** pqrs | **8** tuv | **9** wxyz |
|   | **0** space |   |

Following the guide, **2** becomes &quot; **a**&quot;, **22** becomes &quot; **b**&quot; and so on.

### Input

- On the first line, you will receive **n** - the **number of characters** – **integer** in the range **[1…30]**
- On the next n lines, you will receive integers, representing the **text message characters**.

### Output

Print all the characters together, forming a **text message string**.

### Examples

| **Input** | **Output** |   | **Input** | **Output** |   | **Input** | **Output** |
| --- | --- | --- | --- | --- | --- | --- | --- |
| 54433555555666 | hello | 9443399908443377733 | hey there | 76333380633 | meet me |

### Hints

- A naïve approach would be to just put all the possible combinations of digits in a giant **switch** statement.
- A cleverer approach would be to come up with a **mathematical formula** , which **converts** a **number** to its **alphabet** representation:

| **Digit** | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |
| **Index** | 0 1 2 | 3 4 5 | 6 7 8 | 9 11 12 | 13 14 15 | 16 17 18 19 | 20 21 22 | 23 24 25 26 |
| **Letter** | a b c | d e f | g h i | j  k  l | m  n  o | p  q  r  s | t u v | w  x  y  z |

- Let&#39;s take the number **222** ( **c** ) for example. Our algorithm would look like this:
  - Find the **number of digits** the number has &quot;e.g. **222**** 3 digits**&quot;
  - Find the **main digit** of the number &quot;e.g.   **222**** 2**&quot;
  - Find the **offset** of the number. To do that, you can use the formula: **(main digit - 2) \* 3**
  - If the main digit is **8 or 9** , we need to **add 1** to the **offset** , since the digits **7** and **9** have **4 letters each**
  - Finally, find the **letter index** (a 0, c 2, etc.). To do that, we can use the following formula: **(offset + digit length - 1)**.
  - After we&#39;ve found the **letter index** , we can just add that to **the ASCII code** of the lowercase letter &quot; **a**&quot; (97)