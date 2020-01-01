Feature: WeatherMap
	As a QA Software Developer
	I want to test of max temp of city

Scenario: MaxTempCity
	* 'http://api.openweathermap.org/data/2.5/forecast?' with id 'id=5128638&' and appId 'APPID=2ab7da09463f1cc26be3358b6a52eb77' and the max_temperature should be bigger than '10' Celsius
