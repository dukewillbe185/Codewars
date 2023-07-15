# DESCRIPTION:
# You're going on a trip with some students and it's up to you to keep track of how much money each Student has. A student is defined like this:

# class Student:
#     def __init__(self, name, fives, tens, twenties):
#         self.name = name
#         self.fives = fives
#         self.tens = tens
#         self.twenties = twenties
# As you can tell, each Student has some fives, tens, and twenties. Your job is to return the name of the student with the most money. If every student has the same amount, then return "all".

# Notes:

# Each student will have a unique name
# There will always be a clear winner: either one person has the most, or everyone has the same amount
# If there is only one student, then that student has the most money
def most_money(students):
    # NOTE: the Student class is preloaded
    if len(students) == 1:
        return students[0].name
    
    money = {}
    total_value = 0
    max_value = 0
    for student in students:
        student_value = 5*student.fives + 10*student.tens + 20*student.twenties
        money[student.name] = student_value
        total_value += student_value
        max_value = max(max_value, student_value)
        
    if total_value // max_value == len(students):
        return "all"
    else:
        return max(money, key = money.get)