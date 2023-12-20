CREATE DATABASE HMBank;

USE HMBank;

CREATE TABLE Customers (
    customer_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    DOB DATE,
    email VARCHAR(100),
    phone_number VARCHAR(15),
    address VARCHAR(255)
);


CREATE TABLE Accounts (
    account_id INT PRIMARY KEY,
    customer_id INT,
    account_type VARCHAR(50),
    balance DECIMAL(10, 2),
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id)
);


CREATE TABLE Transactions (
    transaction_id INT PRIMARY KEY,
    account_id INT,
    transaction_type VARCHAR(50),
    amount DECIMAL(10, 2),
    transaction_date DATE,
    FOREIGN KEY (account_id) REFERENCES Accounts(account_id)
);

---------------------------------------------------------------------------------


INSERT INTO Customers VALUES
(1, 'Ravi', 'Kumar', '1980-01-01', 'ravi.kumar@example.com', '9876543210', '123 Delhi St'),
(2, 'Sunita', 'Sharma', '1985-02-02', 'sunita.sharma@example.com', '9876543211', '456 Mumbai St'),
(3, 'Amit', 'Patel', '1990-03-03', 'amit.patel@example.com', '9876543212', '789 Kolkata St'),
(4, 'Vijay', 'Verma', '1975-04-04', 'vijay.verma@example.com', '9876543213', '123 Bangalore St'),
(5, 'Priya', 'Singh', '1982-05-05', 'priya.singh@example.com', '9876543214', '456 Chennai St'),
(6, 'Rajesh', 'Gupta', '1988-06-06', 'rajesh.gupta@example.com', '9876543215', '789 Hyderabad St'),
(7, 'Anita', 'Dey', '1978-07-07', 'anita.dey@example.com', '9876543216', '123 Pune St'),
(8, 'Suresh', 'Das', '1983-08-08', 'suresh.das@example.com', '9876543217', '456 Kolkata St'),
(9, 'Rani', 'Roy', '1992-09-09', 'rani.roy@example.com', '9876543218', '789 Delhi St'),
(10, 'Rahul', 'Bose', '1981-10-10', 'rahul.bose@example.com', '9876543219', '123 Mumbai St');


INSERT INTO Accounts VALUES
(1, 1, 'savings', 10000.00),
(2, 2, 'current', 20000.00),
(3, 3, 'savings', 15000.00),
(4, 4, 'current', 25000.00),
(5, 5, 'savings', 20000.00),
(6, 6, 'current', 30000.00),
(7, 7, 'savings', 25000.00),
(8, 8, 'current', 35000.00),
(9, 9, 'savings', 30000.00),
(10, 10, 'current', 40000.00);


INSERT INTO Transactions VALUES
(1, 1, 'deposit', 5000.00, '2023-01-01'),
(2, 2, 'withdrawal', 3000.00, '2023-02-02'),
(3, 3, 'deposit', 4000.00, '2023-03-03'),
(4, 4, 'withdrawal', 5000.00, '2023-04-04'),
(5, 5, 'deposit', 6000.00, '2023-05-05'),
(6, 6, 'withdrawal', 7000.00, '2023-06-06'),
(7, 7, 'deposit', 8000.00, '2023-07-07'),
(8, 8, 'withdrawal', 9000.00, '2023-08-08'),
(9, 9, 'deposit', 10000.00, '2023-09-09'),
(10, 10, 'withdrawal', 11000.00, '2023-10-10');

-------------------------------------------------------------------------

-- Task 2: Select, Where, Between, AND, LIKE
-- 1. Retrieve the name, account type and email of all customers
SELECT first_name, last_name, account_type, email
FROM Customers c
JOIN Accounts a ON c.customer_id = a.customer_id;

-- 2. List all transactions for a specific customer
SELECT t.*
FROM Transactions t
JOIN Accounts a ON t.account_id = a.account_id
WHERE a.customer_id = 1;  

-- 3. Increase the balance of a specific account by a certain amount
UPDATE Accounts
SET balance = balance + 1000  
WHERE account_id = 1;  

-- 4. Combine first and last names of customers as a full_name
SELECT CONCAT(first_name, ' ', last_name) AS full_name
FROM Customers;

-- 5. Remove accounts with a balance of zero where the account type is savings
DELETE FROM Accounts
WHERE balance = 0 AND account_type = 'savings';

-- 6. Find customers living in a specific city
SELECT *
FROM Customers
WHERE address LIKE '%Delhi%';  

-- 7. Get the account balance for a specific account
SELECT balance
FROM Accounts
WHERE account_id = 1;  

-- 8. List all current accounts with a balance greater than $1,000
SELECT *
FROM Accounts
WHERE account_type = 'current' AND balance > 1000;

-- 9. Retrieve all transactions for a specific account
SELECT *
FROM Transactions
WHERE account_id = 1;  

-- 10. Calculate the interest accrued on savings accounts based on a given interest rate
SELECT account_id, balance * 0.05 AS interest  
FROM Accounts
WHERE account_type = 'savings';

-- 11. Identify accounts where the balance is less than a specified overdraft limit
SELECT *
FROM Accounts
WHERE balance < -500;  

-- 12. Find customers not living in a specific city
SELECT *
FROM Customers
WHERE address NOT LIKE '%Delhi%';  

-----------------------------------------------------------------------------------------------------------------

-- Task 3: Aggregate functions, Having, Order By, GroupBy and Joins
-- 1. Find the average account balance for all customers
SELECT AVG(balance) AS average_balance
FROM Accounts;

-- 2. Retrieve the top 10 highest account balances
SELECT TOP 10*
FROM Accounts
ORDER BY balance DESC;

-- 3. Calculate Total Deposits for All Customers in a specific date
SELECT SUM(amount) AS total_deposits
FROM Transactions
WHERE transaction_type = 'deposit' AND transaction_date = '2023-01-01'; 

-- 4. Find the Oldest and Newest Customers
SELECT MIN(DOB) AS oldest_customer, MAX(DOB) AS newest_customer
FROM Customers;

-- 5. Retrieve transaction details along with the account type
SELECT t.*, a.account_type
FROM Transactions t
JOIN Accounts a ON t.account_id = a.account_id;

-- 6. Get a list of customers along with their account details
SELECT c.*, a.*
FROM Customers c
JOIN Accounts a ON c.customer_id = a.customer_id;

-- 7. Retrieve transaction details along with customer information for a specific account
SELECT t.*, c.*
FROM Transactions t
JOIN Accounts a ON t.account_id = a.account_id
JOIN Customers c ON a.customer_id = c.customer_id
WHERE a.account_id = 1;  

-- 8. Identify customers who have more than one account
SELECT customer_id
FROM Accounts
GROUP BY customer_id
HAVING COUNT(account_id) > 1;

-- 9. Calculate the difference in transaction amounts between deposits and withdrawals
SELECT SUM(CASE WHEN transaction_type = 'deposit' THEN amount ELSE -amount END) AS net_amount
FROM Transactions;

-- 10. Calculate the average daily balance for each account over a specified period


-- 11. Calculate the total balance for each account type
SELECT account_type, SUM(balance) AS total_balance
FROM Accounts
GROUP BY account_type;

-- 12. Identify accounts with the highest number of transactions order by descending order
SELECT account_id, COUNT(transaction_id) AS transaction_count
FROM Transactions
GROUP BY account_id
ORDER BY transaction_count DESC;

-- 13. List customers with high aggregate account balances, along with their account types
SELECT c.*, a.account_type, SUM(a.balance) AS total_balance
FROM Customers c
JOIN Accounts a ON c.customer_id = a.customer_id
GROUP BY c.customer_id, a.account_type
HAVING SUM(a.balance) > 10000;  

-- 14. Identify and list duplicate transactions based on transaction amount, date, and account
SELECT amount, transaction_date, account_id, COUNT(*) AS count
FROM Transactions
GROUP BY amount, transaction_date, account_id
HAVING COUNT(*) > 1;

-- Task 4: Subquery and its type
-- 1. Retrieve the customer(s) with the highest account balance
SELECT customer_id
FROM Accounts
WHERE balance = (SELECT MAX(balance) FROM Accounts);

-- 2. Calculate the average account balance for customers who have more than one account
SELECT customer_id, AVG(balance) AS average_balance
FROM Accounts
GROUP BY customer_id
HAVING COUNT(account_id) > 1;

-- 3. Retrieve accounts with transactions whose amounts exceed the average transaction amount
SELECT DISTINCT account_id
FROM Transactions
WHERE amount > (SELECT AVG(amount) FROM Transactions);

-- 4. Identify customers who have no recorded transactions
SELECT customer_id
FROM Customers
WHERE customer_id NOT IN (SELECT DISTINCT customer_id FROM Accounts WHERE account_id IN (SELECT DISTINCT account_id FROM Transactions));

-- 5. Calculate the total balance of accounts with no recorded transactions
SELECT SUM(balance) AS total_balance
FROM Accounts
WHERE account_id NOT IN (SELECT DISTINCT account_id FROM Transactions);

-- 6. Retrieve transactions for accounts with the lowest balance
SELECT *
FROM Transactions
WHERE account_id = (SELECT account_id FROM Accounts WHERE balance = (SELECT MIN(balance) FROM Accounts));

-- 7. Identify customers who have accounts of multiple types
SELECT customer_id
FROM Accounts
GROUP BY customer_id
HAVING COUNT(DISTINCT account_type) > 1;

-- 8. Calculate the percentage of each account type out of the total number of accounts
SELECT account_type, COUNT(*) * 100.0 / (SELECT COUNT(*) FROM Accounts) AS percentage
FROM Accounts
GROUP BY account_type;

-- 9. Retrieve all transactions for a customer with a given customer_id
SELECT *
FROM Transactions
WHERE account_id IN (SELECT account_id FROM Accounts WHERE customer_id = 1);  

-- 10. Calculate the total balance for each account type, including a subquery within the SELECT clause
SELECT account_type, (SELECT SUM(balance) FROM Accounts a2 WHERE a1.account_type = a2.account_type) AS total_balance
FROM Accounts a1
GROUP BY account_type;

		