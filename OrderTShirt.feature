Feature: OrderTShirt
	To order a T shirt and verify in order history

@Scenario1
Scenario Outline: Order a T shirt and verify in order history

Given I navigate to website 
When I click on T-Shirts tab
And I select the image displayed
And select add to cart
When I proceed to checkout
And user proceed to check out again
And I enter an email address to create an account '<email>'
When user select Create an account button
When user fills the personal information '<Title>', '<first_name>', '<last_name>', '<password>', '<day>', '<month>', '<year>'
And fills the Address section '<address>', '<city>', '<state>', '<zip_code>','<mobile_phone>'
When I click on Register button
And I proceed to checkout
And I select the tick box for terms of service and proceed to checkout
And I select pay by check
And I select I confirm my order
When I select My Orders at the bottom of the screen
Then I click the order reference number and primt out order ref number

Examples: 
|      email          | Title   |     first_name     | last_name      | password | day  | month        | year     |     address   | city    | state    | zip_code | mobile_phone  |
|  amex@gmail.com     |   Mr    |     Jonathan       |    Bergs       | abcdefg  |  8   |  January     | 1985     |    MossSide   | Chicago | Illinois |  00097   |  078987548722 |

