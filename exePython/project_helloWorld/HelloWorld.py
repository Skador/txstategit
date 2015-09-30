__author__ = 'ckern1'

from math import *

print "Hello World"
print ""
#int num = 5
num=5

num=73
sen="Butts."
print sen+str(num)
num=str(num)
print len(num)
print ""

str_1 = "Chocolate"
str_2 = "delicious"

print "%s is super %s."%(str_1,str_2)
print ""

num2 = raw_input("Input a number: ")
print num2

x = "There are %d types of people" % 10
binary = "binary"
do_not = "don't"
y = "Those hwo know %s and those who %s." % (binary, do_not)

print x
print y

print "I said: %r." % x
print "I also said: '%s'." % y

hilarious = False

vari = raw_input("Input another variable number: ")

if (vari == 2 or vari == 3):
  print str(vari) + "if."
elif (vari == 1 or vari == 4):
  print str(vari) + " elif."
else:
  print str(vari) + " else."

num_sqrt = sqrt(float(vari))
print str(num_sqrt) + " is the square root of " + vari +"."

list_name = [42, 26, 5, 3, 12]

print(list_name[1:4])

str_5 = "hellosixmonster"

print(str_5[5:8])

print(str_5.index("six"))

# For loooooops

for i in list_name:
  print(i)

# Dictionaries

stark = {'Rob':1, 'Sansa':2, 'Arya':3, 'Bran':4, 'Baby Stark':5}
stark['John']=42

print stark['Arya']

for kid in stark:
  print stark[kid]

del stark ['Rob']

stark['Sansa'] = 69

inventory = ['hookshot', 'boomerang', 'master sword', 'bitches']

inventory.remove('hookshot')

hyrule = {'triforce':['wisdom','courage','power'],'jars':['fairy','red potion','blue potion','fish'], 'zelda':69,
          'rupees':999, 'monsters':['Ganon','keese','Dark knuts', 'Cuccoos', 'occtorocks']}

for thing in hyrule:
  print hyrule[thing]

hyrule['triforce'].remove('power')
hyrule['rupees']=hyrule['rupees']-200

for thing2 in hyrule:
  print hyrule[thing2]

print hyrule['jars'].sort()
