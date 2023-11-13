import subprocess
from string import punctuation


def lite_file(directory: str, name: str) -> bool:
    result = subprocess.run(directory, shell=True, stdout=subprocess.PIPE, encoding='utf-8')
    out = result.stdout
    if result.returncode == 0:
        lst = out.split("\n")
        if name in lst:
            return True
        return False
    return False


def hard_file(directory: str, name: str, word='Yes') -> bool:
    result = subprocess.run(directory, shell=True, stdout=subprocess.PIPE, encoding='utf-8')
    out = result.stdout
    if result.returncode == 0:
        lst = out.split("\n")
        if name in lst:
            for x in name:
                if x in punctuation:
                    name = name.replace(x, " ")
            if word in name:
                print('Find')
            else:
                print('No find')
            return True
        return False
    return False


if __name__ == '__main__':
    print(lite_file('cat /etc/os-release', 'VERSION="22.04.1 LTS (Jammy Jellyfish)"'))
    print(hard_file('cat /etc/os-release', 'VERSION="22.04.1 LTS (Jammy Jellyfish)"', '04'))
