# Buber Dinner Api

-[Buber Dinner Api](#buber-dinner-api)
	- [Auth](#auth)
		- [Register](#register)
		  - [Register Request](#register-request)
		  - [Register Response](#register-response)
		- [Login](#login)
		  - [Login Request](#login-request)
		  - [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```
#### Register Request

```json
{
	"firstName":"John",
	"lastName":"Doe",
	"email":"john@domain.com",
	"password":"P@ssw0rd!",
}
```

#### Register Response

``` js
200 OK
```

### Login

``` js
POST {{host}}/auth/login
```
#### Login Request


``` json
{
	"email":"john@domain.com",
	"password":"P@ssw0rd!",
}
```

#### Login Response

``` js
{
	"firstName":"John",
	"lastName":"Doe",
	"email":"john@domain.com",
	"token":"pajdmgpasmjgpasgv"
}
```