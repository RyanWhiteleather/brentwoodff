import '@mantine/core/styles.css';
import { AppShell, Burger, Group, MantineProvider, Image, Title } from '@mantine/core';
import { Router } from './Router';
import { theme } from './theme';
import { useDisclosure } from '@mantine/hooks';
import { Navbar } from './layouts/Navbar';

export default function App() {
  const [opened, { toggle }] = useDisclosure();
  return (
    <MantineProvider theme={theme}>
              <AppShell
      header={{ height: 100 }}
      navbar={{
        width: 300,
        breakpoint: 'sm',
        collapsed: { mobile: !opened },
      }}
      padding="md"
    >
      <AppShell.Header>
        <Burger
          opened={opened}
          onClick={toggle}
          hiddenFrom="sm"
          size="sm"
        />
       <Group justify='center'>
          <Image src="src/assets/logo.jpg" w="95px" fit="contain" h="auto" radius="small" />
          <Title order={2}>Brentwood Browdown Fantasy Football</Title>
            
          </Group>
      </AppShell.Header>

      <AppShell.Navbar p="md"><Navbar/></AppShell.Navbar>

      <AppShell.Main> 
        <Router></Router>
      </AppShell.Main>
    </AppShell>
    </MantineProvider>
  );
}
