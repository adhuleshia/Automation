Feature: AddRemoveItemsInShoppingCart
	In order to shop from ecommerce website
	As a customer
	I want to be able to update items to shopping cart

Background: Ecommerce website
	Given an ecommerce website
	And site sells desktop computers
	And site sells books


@FT
Scenario Outline: Add items to cart
Scenario:Add cheapest computer item to cart
	Given customer navigated to website
	And navigated to Desktops page using menu item Computers > Desktops
	And sorted items Price Low to High
	When customer clicks Add on first in the list
	And clicks on Shopping cart link from pop-up window
	Then the shopping cart has <quantity> of <ComputerItem>
	Examples: 
	| ComputerItem|quantity |
	| PC  | 1        |

@FT
Scenario: Add book item to cart
	Given customer navigated to website
	And navigated to Desktops page using menu item Computers > Desktops
	And sorted items Price Low to High
	And customer clicks Add on first in the list
	And customer navigated to Books page using menu item Books
	When customer click Add on first <BookItem> in the list
	And clicks on Shopping cart link from pop-up window
	Then the shopping cart has <quantity> of <ComputerItem>
	And cart has <countOfBooks> of <BookItem>
	And Total is $<cartTotal>
	Examples: 
	| ComputerItem | BookItem	 | countOfBooks | cartTotal | quantity |
	| PC		   | Fahrenheit  | 1            | 527.00    | 1        |
	
@FT
Scenario Outline: Remove items from the cart
Scenario: Remove desktop item from the cart
	Given customer navigated to website
	And added <qtyOfDesktops> firstDesktop <ComputerItem> of price $<costPerDesktop> to shopping cart
	And added <qtyOfBooks> firstBook <BookItem> of price $<costPerBook> to shopping cart
	And total of shopping cart is $<InitialCartTotal>
	When customer clicks on Remove for <qtyOfDesktops> book item in the list
	Then cart has <qtyOfBooks> of <BookItem>
	And total of shopping cart is $<FinalCartTotal>	
	Examples: 
	| ComputerItem | qtyOfDesktops | ComputerPrice | qtyOfBooks | costPerBook | FinalCartTotal | BookItem   | InitialCartTotal |
	| PC           | 1             | 500.00        | 1          | 27.00       | 27.00          | Fahrenheit | 527.00           |