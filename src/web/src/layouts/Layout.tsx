import { Welcome } from '../components/Welcome/Welcome';
import { ColorSchemeToggle } from '../components/ColorSchemeToggle/ColorSchemeToggle';
import { AppShell, Burger, Group, Image, Title } from '@mantine/core';
import { useDisclosure } from '@mantine/hooks';

export function Layout() {
  const [opened, { toggle }] = useDisclosure();
  return (
    <>
        <AppShell
      header={{ height: 60 }}
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

      <AppShell.Navbar p="md">Navbar</AppShell.Navbar>

      <AppShell.Main> 
        <Welcome />
        <ColorSchemeToggle /></AppShell.Main>
    </AppShell>
    </>
  );
}