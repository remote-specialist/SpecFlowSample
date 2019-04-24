Feature: Foo
	
@jsonDataSource @jsonDataSourcePath:DataSource\FooResponse.json
Scenario: Validate Foo functionality
Given user has access to the Application Service
When user invokes Foo functionality
| FooRequestValue |
| input           |
Then Foo functionality should complete successfully