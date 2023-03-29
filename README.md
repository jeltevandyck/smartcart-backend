# Smartcart REST API

![image](https://github.com/jeltevandyck/smartcart-backend/blob/master/logo.png)

## Address

#### GET `/api/address`
Returns a list of all addresses.

**Query parameters**
- `page` - The page number to return. Default is 0.
- `size` - The number of items to return. Default is 10.

#### POST `/api/address`
Creates a new address.

**Request body**
```json
{
  "street": "string",
  "number": "string",
  "extra": "string", //optional
  "postalCode": "string",
  "Country": "string",
  "State": "string"
}
```

#### GET `/api/address/{id}`
Returns the address with the given id.

#### PUT `/api/address/`
Updates the address.

**Request body**
```json
{
  "id": "string",
  "street": "string",
  "number": "string",
  "extra": "string", //optional
  "postalCode": "string",
  "Country": "string",
  "State": "string"
}
```

#### DELETE `/api/address/`
Deletes the address.

**Request body**
```json
{
  "id": "string"
}
```

### Cart

#### GET `/api/cart`
Returns a list of all carts.

#### POST `/api/cart`
Creates a new cart.

**Request body**
```json
{
  "storeId": "string"
}
```

#### GET `/api/cart/{id}`
Returns the cart with the given id.

#### PUT `/api/cart/`
Updates the cart.

**Request body**
```json
{
  "id": "string",
  "storeId": "string",
  "ChangeCode": "boolean",
  "Status": "string" //optional
}
```

#### DELETE `/api/cart/`
Deletes the cart.

**Request body**
```json
{
  "id": "string"
}
```

### Order

#### GET `/api/order`
Returns a list of all orders.

#### POST `/api/order`
Creates a new order.

**Request body**
```json
{
  "userId": "string"
}
```

#### GET `/api/order/{id}`
Returns the order with the given id.

#### PUT `/api/order/`
Updates the order.

**Request body**
```json
{
  "id": "string",
  "userId": "string"
}
```

##### DELETE `/api/order/`
Deletes the order.

**Request body**
```json
{
  "id": "string"
}
```

### Product

#### GET `/api/product`
Returns a list of all products.

#### POST `/api/product`
Creates a new product.

**Request body**

```json
{
  "name": "string",
  "description": "string",
  "price": "number",
  "discount": "number",
  "discountPercentage": "number",
  "amount": "number",
  "expirationDate": "date",
  "productionDate": "date",
  "storeId": "string"
}
```

#### GET `/api/product/{id}`
Returns the product with the given id.

#### PUT `/api/product/`
Updates the product.

**Request body**
```json
{
  "id": "string",
  "name": "string",
  "description": "string",
  "price": "number",
  "discount": "number",
  "discountPercentage": "number",
  "amount": "number",
  "expirationDate": "date",
  "productionDate": "date", //optional
  "storeId": "string"
}
```

#### DELETE `/api/product/`
Deletes the product.

**Request body**
```json
{
  "id": "string"
}
```

### Store

#### GET `/api/store`
Returns a list of all stores.

#### POST `/api/store`
Creates a new store.

**Request body**
```json
{
  "name": "string",
  "addressId": "string"
}
```

#### GET `/api/store/{id}`
Returns the store with the given id.

#### PUT `/api/store/`
Updates the store.

**Request body**
```json
{
  "id": "string",
  "name": "string",
  "addressId": "string"
}
```

#### DELETE `/api/store/`
Deletes the store.

**Request body**
```json
{
  "id": "string"
}
```

### User

#### GET `/api/user`
Returns a list of all users.

#### POST `/api/user`
Creates a new user.

**Request body**
```json
{
  "firstName": "string",
  "lastName": "string",
  "email": "string",
  "birthDate": "date"
}
```

#### GET `/api/user/{id}`
Returns the user with the given id.

#### PUT `/api/user/`
Updates the user.

**Request body**
```json
{
  "id": "string",
  "firstName": "string",
  "lastName": "string",
  "email": "string",
  "birthDate": "date"
}
```

#### DELETE `/api/user/`
Deletes the user.

**Request body**
```json
{
  "id": "string"
}
```

