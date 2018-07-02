# AsyncMultiTcpIp

Objective
The objective of this article is to demonstrate a socket-based client/server 
application that will allow two-way asynchronous communication between a server and multiple client applications. 
Because this example uses asynchronous methods, the server application does not use threads to communicate to multiple clients 
(although internally the asynchronous communication mechanism uses threads at the OS level).
