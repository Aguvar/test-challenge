from faker import Faker
import json
fake = Faker()

employees = []

dataToGenerate = {'HR':
                  {1: 5,
                  2: 2,
                  3: 13},
                  'Engineering':
                  {1: 50,
                  2: 68,
                  3: 32},
                  'Artist':
                  {1: 5,
                  2: 20},
                  'Design':
                  {1: 10,
                  3: 15},
                  'PMs':
                  {1: 10,
                  2: 20},
                  'CEO':
                  {0: 1}}

for area in dataToGenerate:
    for seniority in dataToGenerate[area]:
        for x in range(dataToGenerate[area][seniority]):
            employees.append({'name': fake.name(), 'area': area, 'seniority': seniority})

with open("data.json", "w+") as outfile:
    json.dump(employees, outfile)

salaries = {'HR':
            {1: 1500,
            2: 1000,
            3: 500},
            'Engineering':
            {1: 5000,
            2: 3000,
            3: 1500},
            'Artist':
            {1: 2000,
            2: 1200},
            'Design':
            {1: 2000,
            3: 800},
            'PMs':
            {1: 4000,
            2: 2400},
            'CEO':
            {0: 20000}}

with open("salaries.json", "w+") as outfile:
    json.dump(salaries, outfile)

salaryIncrements = {'HR':
            {1: 5,
            2: 2,
            3: 0.5},
            'Engineering':
            {1: 10,
            2: 7,
            3: 5},
            'Artist':
            {1: 5,
            2: 2.5},
            'Design':
            {1: 7,
            3: 4},
            'PMs':
            {1: 10,
            2: 5},
            'CEO':
            {0: 100}}

with open("salaryIncrements.json", "w+") as outfile:
    json.dump(salaryIncrements, outfile)