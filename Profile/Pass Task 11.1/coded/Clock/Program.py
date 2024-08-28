from Clock import Clock

if __name__ == "__main__":
    clock = Clock()
    for i in range(86450):
        clock.tick()
        print(clock.time())